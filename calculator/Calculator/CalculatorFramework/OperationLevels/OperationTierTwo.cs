using CalculatorFramework.Interfaces;

namespace CalculatorFramework.OperationLevels
{
    public class OperationTierTwo : IOperationTier
    {
        public string TierName { get; set; }
        public IOperationTier Next { get; set; }
        public IOperationTier Previous { get; set; }

        public OperationTierTwo()
        {
            TierName = "OperationTierTwo";
            Next =  new OperationTierOne();
            Previous = null;
        }
    }
}
