using CalculatorFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace CalculatorFramework
{
    public class CalculatorServices
    {
        private HashSet<char> _acceptedOperationCharacters;
        public List<IMathOperation> SupportedOperations { get; private set; }
        private char[] _invalidOperationCharacters;
        private string _groupingSymbolLeft;
        private string _groupingSymbolRight;
        private Dictionary<string, IMathOperation> _operandDictionary;

        public CalculatorServices()
        {
            AddInvalidOperationCharacters();
            UpdateGroupingSymbols();
            SupportedOperations = UpdateMathOperations();
            _acceptedOperationCharacters = PopulateAcceptedOperationCharacters();
            SetupOperandDictionary();
        }

        private void SetupOperandDictionary()
        {
            _operandDictionary = new Dictionary<string, IMathOperation>();
            foreach (IMathOperation operation in SupportedOperations)
            {
                _operandDictionary.Add(operation.Symbol, operation);
            }
        }

        private void UpdateGroupingSymbols()
        {
            _groupingSymbolLeft = "(";
            _groupingSymbolRight = ")";
        }

        protected void AddInvalidOperationCharacters()
        {
            _invalidOperationCharacters = new char[] {
                '.'
                };
        }

        public string ProcessUserInput(string input)
        {
            if (UserInputIsVerified(input))
            {
                char[] parsedInput = StringToCharArrayDroppingWhitespace(input);
                List<string> tokens = TokenizeCharacters(parsedInput);
                return CalculateInput(tokens);
            }
            else return null;
        }

        private string CalculateInput(List<string> tokens)
        {
            List<string> tks = new List<string>(tokens);
            while (tks.Contains(_groupingSymbolLeft) && tks.Contains(_groupingSymbolRight))
            {
                int groupingSymbolRightIndex;
                int groupingSymbolLeftIndex;
                int i = 0;
                while (tks[i] != _groupingSymbolRight)
                {
                    i++;
                }
                groupingSymbolRightIndex = i;
                while (tks[i] != _groupingSymbolLeft)
                {
                    i--;
                }
                groupingSymbolLeftIndex = i;
                tks = tokens.GetRange(groupingSymbolLeftIndex + 1, groupingSymbolRightIndex);
                string result = CalcTokensSubset(tks);
                tks = ReplaceIndexRangeWithValue(tks, groupingSymbolLeftIndex, groupingSymbolRightIndex + 1, result);
            }
            string solution = CalcTokensSubset(tks);
            return solution;
        }

        private string CalcTokensSubset(List<string> tks)
        {
            List<string> tokens = new List<string>(tks);
            while (tokens.Count > 1)
            {
                SortedDictionary<double, int> weightIndexDict = new SortedDictionary<double, int>();
                MathExpression expression = new MathExpression();
                for (int p = 0; p < tokens.Count; p++)
                {
                    try
                    {
                        weightIndexDict.Add(_operandDictionary[tokens[p]].OperationTier, p);
                    }
                    catch(Exception ex)
                    {}
                }
                int indexToCalc = weightIndexDict.Values.First();
                expression.Operand = tokens[indexToCalc];
                expression.Left = Convert.ToDecimal(tokens[indexToCalc-1]);
                expression.Right = Convert.ToDecimal(tokens[indexToCalc+1]);
                string result = RunExpression(expression);
                tokens = ReplaceIndexRangeWithValue(tokens, indexToCalc-1, indexToCalc+1, result);
            }
            string finalResult = tokens[0];
            return finalResult;
        }

        private List<string> ReplaceIndexRangeWithValue(List<string> tokens, int indexLeft, int indexRight, string value)
        {
            List<string> newTokens = new List<string>();
            int i = 0;
            while (i < indexLeft)
            {
                newTokens.Add(tokens[i]);
                i++;
            }
            newTokens.Add(value);
            while ( i <= indexRight)
            {
                i++;
            }
            while (i < tokens.Count)
            {
                newTokens.Add(tokens[i]);
                i++;
            }
            return newTokens;
        }

        private string RunExpression(MathExpression expression)
        {
            string result = _operandDictionary[expression.Operand].Calculate(expression.Left, expression.Right).ToString();
            return result;
        }

        public List<string> TokenizeCharacters(char[] verifiedParsedInput)
        {
            List<string> tokens = new List<string>();
            string token = "";
            foreach (char c in verifiedParsedInput)
            {
                if (token.Length > 0)
                {
                    if (token == _groupingSymbolLeft || token == _groupingSymbolRight)
                    {
                        tokens.Add(token);
                        token = "";
                    }
                    else if (char.IsNumber(c) || c == '.')
                    {
                        TokenizeNumberHelper(ref token, c, tokens);
                    }
                    else
                    {
                       TokenizeSymbolHelper(ref token, c, tokens);
                    }
                }
                else
                {
                    token += c;
                }
            }
            if (token[0] == '-')
            {
                tokens.Add(token[0].ToString());
                token = token.TrimStart('-');
            }
            tokens.Add(token);
            return tokens;
        }

        private void TokenizeNumberHelper(ref string tokenRef, char c, List<string> tokens)
        {
            char lastChar = tokenRef[tokenRef.Length-1];
            if (lastChar == '-' && tokenRef.Length > 1)
            {
                tokenRef = tokenRef.TrimEnd('-');
                tokens.Add(tokenRef);
                tokenRef = "" + lastChar + c;
            }
            else if (char.IsNumber(lastChar) || lastChar == '-' || lastChar == '.')
            {
                tokenRef += c;
            }
            else
            {
                tokens.Add(tokenRef);
                tokenRef = "" + c;
            }
        }

        private void TokenizeSymbolHelper(ref string tokenRef, char c, List<string> tokens)
        {
            char lastChar = tokenRef[tokenRef.Length-1];
            if (char.IsNumber(lastChar) || lastChar == '.')
            {
                tokens.Add(tokenRef);
                tokenRef = "" + c;
            }
            else
            {
                tokenRef += c;
            }
        }

        public bool UserInputIsVerified (string input)
        {
            char[] inputCharacters = StringToCharArrayDroppingWhitespace(input);
            int length = inputCharacters.Length;
            string potentialSymbol = "";
            int groupingSymbolLeftCount = 0;
            int groupingSymbolRightCount = 0;
            if (input.Length > 2)
            {
                if (!char.IsNumber(inputCharacters[length-2]) && (!char.IsNumber(inputCharacters[length-1]) && inputCharacters[length-1] != '.'))
                {
                    return false;
                }
                for (int i = 0; i < inputCharacters.Length; i++)
                {
                    if (char.IsNumber(inputCharacters[i]) || inputCharacters[i] == '-' || inputCharacters[i] == '.')
                    {
                        if (potentialSymbol.Length > 0)
                        {
                            if (!SupportedOperations.Select(o => o.Symbol).Contains(potentialSymbol) && _groupingSymbolLeft != potentialSymbol && _groupingSymbolRight != potentialSymbol)
                            {
                                return false;
                            }
                            if (potentialSymbol == _groupingSymbolLeft)
                            {
                                groupingSymbolLeftCount += 1;
                            }
                            if (potentialSymbol == _groupingSymbolRight)
                            {
                                groupingSymbolRightCount += 1;
                            }
                            potentialSymbol = "";
                            continue;
                        }
                        continue;
                    }
                    if (_acceptedOperationCharacters.Contains(inputCharacters[i]))
                    {
                        potentialSymbol += inputCharacters[i];
                        continue;
                    }
                    return false;
                }
            }
            if (groupingSymbolLeftCount == groupingSymbolRightCount) return true;
            return false;
        }

        private char[] StringToCharArrayDroppingWhitespace(string input)
        {
            char[] output = input.ToCharArray().Where(c => !char.IsWhiteSpace(c)).ToArray();
            return output;
        }

        private  List<IMathOperation> UpdateMathOperations()
        {
            List<IMathOperation> operations = MathOperationsLoader.LoadMathOperations();
            List<IMathOperation> verifiedOperations = VerifyMathOperationalConsistency(operations);
            return verifiedOperations;
        }

        private HashSet<char> PopulateAcceptedOperationCharacters()
        {
            HashSet<char> acceptableOperationSymbols = new HashSet<char>(SupportedOperations.SelectMany(o => o.Symbol));
            foreach (char c in _groupingSymbolLeft.Select(c => c))
            {
                acceptableOperationSymbols.Add(c);
            }
            foreach (char c in _groupingSymbolRight.Select(c => c))
            {
                acceptableOperationSymbols.Add(c);
            }
            return acceptableOperationSymbols;
        }

        private List<IMathOperation> VerifyMathOperationalConsistency(List<IMathOperation> operations) //def test, especially updating list without returning it
        {
            List<IMathOperation> verifiedOperations = new List<IMathOperation>();
            foreach (IMathOperation operation in operations)
            {
                if (!string.IsNullOrWhiteSpace(operation.Symbol) && !string.IsNullOrWhiteSpace(operation.Name))
                {
                    if (operation.Symbol == _groupingSymbolLeft || operation.Symbol == _groupingSymbolRight)
                    {
                        try
                        {
                            throw new InvalidFilterCriteriaException($"Operation symbol matched a grouping symbol. The {operation.Name} operation was removed from the list.");
                        }
                        catch (InvalidFilterCriteriaException)
                        {
                            continue;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < operation.Symbol.Length; i++)
                        {
                            if (_invalidOperationCharacters.Contains(operation.Symbol[i]) || (operation.Symbol[i] == '-' && operation.Symbol.Length > 1))
                            {
                                try
                                {
                                    throw new InvalidFilterCriteriaException($"Operation symbol contained invalid characters. The {operation.Name} operation was removed from the list.");
                                }
                                catch (InvalidFilterCriteriaException)
                                {
                                    break;
                                }
                            }
                            if (i == operation.Symbol.Length-1)
                            {
                                verifiedOperations.Add(operation);
                            }
                        }
                        
                    }
                }
                else
                {
                    try
                    {
                        throw new NullReferenceException($"The {operation.Name} operation was removed from the list due to having empty/whitespace as a parameter.");
                    }
                    catch (NullReferenceException)
                    {
                        continue;
                    }
                }
                //operation.Name = operation.Name.ToTitleCase make to title case
                operation.Symbol = operation.Symbol.ToLower();
            }
            return verifiedOperations;
        }
    }
}
