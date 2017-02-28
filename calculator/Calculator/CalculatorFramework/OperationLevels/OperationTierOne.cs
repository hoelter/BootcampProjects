using CalculatorFramework.Interfaces;

namespace CalculatorFramework.OperationLevels
{
    public class OperationTierOne : IOperationTier
    {
        public string TierName { get; set; }
        public IOperationTier Next { get; set; }
        public IOperationTier Previous { get; set; }

        public OperationTierOne()
        {
            TierName = "OperationTierOne";
            Next = null;
            Previous = new OperationTierTwo();
        }
    }
}
