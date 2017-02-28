using CalculatorFramework.Interfaces;

namespace MathOperations
{
    public class Subtraction : IMathOperation
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        //public string RequiredFunction { get; set; }
        //public List<IMathOperation> HigherOperations { get; set; }
        //public string MyCalculatorClass { get; set; }
        public double OperationTier { get; set; }

         public Subtraction()
        {
            Name = "Subtraction";
            Symbol = "-";
            OperationTier = 0.2;
           // OperationTier= new OperationTierTwo();
        }

        public decimal Calculate(decimal a, decimal b)
        {
            return a - b;
        }
    }
}
