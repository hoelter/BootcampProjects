using CalculatorFramework.Interfaces;
using System;
using System.Collections.Generic;

namespace CalculatorConsole
{
    public class CommandLineDisplay : IDisplayCalculator
    {
        private List<IMathOperation> _supportedOperations;

        public void ShowStartMenu()
        {
            Console.WriteLine("Welcome to another Calculator!");
            ShowSupportedOperations();
        }

        public void UpdateSupportedOperations(List<IMathOperation> supportedOperations)
        {
             _supportedOperations = supportedOperations;
        }

        public void ShowSupportedOperations()
        {
            Console.WriteLine("\nThis calculator supports the following operations:");
            foreach (IMathOperation operation in _supportedOperations)
            {
                Console.WriteLine($"{operation.Name} using the symbol: {operation.Symbol}");
            }
        }

        public void ShowUserSolution(string solution)
        {
            Console.WriteLine($"The answer is: {solution}");
        }

        public string GetUserExpressionInput()
        {
            Console.Write("\nPlease enter the operation you would like to compute:");
            string input = Console.ReadLine();
            return input;
        }

        public void ThrowUserInputError()
        {
            Console.WriteLine("Invalid input, please enter a valid expression.");
            Console.ReadLine();
            Console.Clear();
        }

        private void FourSecondSleep()
        {
            System.Threading.Thread.Sleep(4000);
        }
    }
}
