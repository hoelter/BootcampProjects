namespace CalculatorFramework.Interfaces
{
    public interface IMathOperation
    {
        string Name { get; set; }
        string Symbol { get; set; }
        double OperationTier { get; set; }

        //public IOperationTier OperationTier { get; set; }
        //string RequiredFunction { get; set; }
        //List<IMathOperation> HigherOperations { get; set; }
        //string MyCalculatorClass { get; set; }

        decimal Calculate(decimal a, decimal b);
    }
}
