using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public abstract class MathDoes
    {
        public List<IMathOperation> Operations { get; protected set; }
        public string GroupingSymbolLeft { get; protected set; }
        public string GroupingSymbolRight { get; protected set; }
        protected char[] _invalidOperationCharacters;

        //If no symbols are set they will default to "(" and ")".
        //Will override if symbols are set as empty/white space.
        //Check invalid operation symbol characters before writing MathOperations for your respective calculator.
        protected abstract void SetGroupingSymbols();

        public void InitializeCalculator()
        {
            Type self = GetType();
            List<IMathOperation> operations = GetMathOperations(self);
            AddInvalidOperationCharacters();
            SetGroupingSymbols();
            GroupingSymbolsCheck();
            VerifyMathOperationalConsistency(self, operations); // does it modify original list or do i need to return?
            Operations = operations;
        }

        protected void AddInvalidOperationCharacters()
        {
            _invalidOperationCharacters = new char[] {
                '-',
                '.'
                };
        }

        protected void GroupingSymbolsCheck()
        {
            if (string.IsNullOrWhiteSpace(GroupingSymbolLeft))
                GroupingSymbolLeft = "(";
            if (string.IsNullOrWhiteSpace(GroupingSymbolRight))
                GroupingSymbolRight = ")";
        }

        protected List<IMathOperation> GetMathOperations(Type self)
        {
            string nameOfSelf = self.Name;
            List<IMathOperation> operations = null;
            try
            {
                operations = (List<IMathOperation>)typeof(MathOperationsLibrary).GetMethod($"Get{nameOfSelf}Operations").Invoke(null, null);
            }
            catch(NullReferenceException) { }
            if (operations == null)
                throw new NullReferenceException($"Operations list was empty in the MathOperationslibrary or matching function called 'Get{nameOfSelf}Operations' does not exist.");
            return operations;
        }

        protected void VerifyMathOperationalConsistency(Type self, List<IMathOperation> operations) //def test
        {
            List<IMathOperation> verifiedOperations = new List<IMathOperation>();
            foreach (IMathOperation operation in operations)
            {
                if (!string.IsNullOrWhiteSpace(operation.RequiredFunction) && !string.IsNullOrWhiteSpace(operation.Symbol) && !string.IsNullOrWhiteSpace(operation.Name))
                {
                    MethodInfo method = self.GetMethod(operation.RequiredFunction, BindingFlags.NonPublic | BindingFlags.Instance/* | BindingFlags.FlattenHierarchy*/);
                    if (method == null)
                    {
                        try
                        {
                            throw new NullReferenceException($"No method was present within the MathDoer {self} for a MathOperation. {operation.Name} was removed from the list.");
                        }
                        catch (NullReferenceException)
                        {
                            continue;
                        }
                    }
                    else if (operation.Symbol == GroupingSymbolLeft || operation.Symbol == GroupingSymbolRight)
                    {
                        try
                        {
                            throw new InvalidFilterCriteriaException($"Operation symbol matched a grouping symbol for MathDoer {self}. The {operation.Name} operation was removed from the list.");
                        }
                        catch (NullReferenceException)
                        {
                            continue;
                        }
                    }
                    else
                    {
                        foreach (char c in operation.Symbol)
                        {
                            if (_invalidOperationCharacters.Contains(c))
                            {
                                try
                                {
                                    throw new InvalidFilterCriteriaException($"Operation symbol contained invalid characters for MathDoer {self}. The {operation.Name} operation was removed from the list.");
                                }
                                catch (InvalidFilterCriteriaException)
                                {
                                    continue;
                                }
                            }
                        }
                        verifiedOperations.Add(operation);
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
            }
            operations = verifiedOperations;
        }
    }
}
