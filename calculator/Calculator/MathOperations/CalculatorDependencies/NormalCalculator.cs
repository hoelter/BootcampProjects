using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    public class NormalCalculator : MathOperationsLoader
    {
        protected override void SetGroupingSymbols()
        {
            GroupingSymbolLeft = "(";
            GroupingSymbolRight = ")";
        }

        private int Add(int a, int b)
        {
            return a + b;
        }

        private int Subtract(int a, int b)
        {
            return a - b;
        }

        private int Divide(int a, int b)
        {
            return a / b;
        }

        private int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
