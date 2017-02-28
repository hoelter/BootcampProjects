using CalculatorFramework.Interfaces;

namespace MathOperations
{
    public class Addition : IMathOperation
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public double OperationTier { get; set; }
        //public string RequiredFunction { get; set; }
        //public IOperationTier OperationTier { get; set; }
       // public string MyCalculatorClass { get; set; }
        
        public Addition()
        {
            Name = "Addition";
            Symbol = "+";
            OperationTier = 0.2;
           // OperationTier= new OperationTierTwo();
        }
        
        public decimal Calculate(decimal a, decimal b)
        {
            return a + b;
        }
    }
}
