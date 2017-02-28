using CalculatorFramework.Interfaces;

namespace MathOperations
{
    public class Division : IMathOperation
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public double OperationTier { get; set; }

        public Division()
        {
            Name = "Division";
            Symbol = "/";
            OperationTier = 0.1;
        }

        public decimal Calculate(decimal a, decimal b)
        {
            return a / b;
        }
    }
}
