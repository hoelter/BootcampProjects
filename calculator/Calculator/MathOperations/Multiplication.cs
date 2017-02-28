using CalculatorFramework.Interfaces;

namespace MathOperations
{
    public class Multiplication : IMathOperation
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        //public string RequiredFunction { get; set; }
        //public List<IMathOperation> HigherOperations { get; set; }
        //public string MyCalculatorClass { get; set; }
        public double OperationTier { get; set; }

        public Multiplication()
        {
            Name = "Multiplication";
            Symbol = "*";
            OperationTier = 0.1;
           // OperationTier= new OperationTierTwo();
        }

        public decimal Calculate(decimal a, decimal b)
        {
            return a * b;
        }
    }
}
