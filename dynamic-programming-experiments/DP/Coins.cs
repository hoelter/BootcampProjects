using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public class Coins
    {
        int[] _coinValues;

        public Coins()
        {
            //_coinValues = new int[] {1, 5, 10, 25, 100, 500, 1000, 2000};
            _coinValues = new int[] {1, 4, 6};
        }

        //get to desiredValue with least amount of coins
        //now tracks the type of coins/bills as well
        public List<int> CalculateCoins(int desiredValue)
        {
            //const int infinity = 1000000000;
            int[] coinValues = _coinValues;

            int numUniqueCoins = coinValues.Length;
            StepInfo[] steps =  new StepInfo[desiredValue + 1];
            for (int i = 0; i < steps.Length; i++)
            {
                steps[i] = new StepInfo();
            }
            steps[0].MinAmountCoins = 0;

            for (int stepValue = 1; stepValue <= desiredValue; stepValue++)
            {
               // int? minimumAmountCoins = infinity;
                List<int> stepCoinValues = new List<int>();
                for (int cvIndex = 0; cvIndex < numUniqueCoins; cvIndex++)
                {
                    if (coinValues[cvIndex] <= stepValue)
                    {
                        int? tempMinAmountCoins = steps[stepValue - coinValues[cvIndex]].MinAmountCoins + 1;

                        if (steps[stepValue].MinAmountCoins > tempMinAmountCoins || steps[stepValue].MinAmountCoins == null)
                        {
                            //minimumAmountCoins = tempMinAmountCoins;
                            //stepCoinValues.Clear();
                            //stepCoinValues.AddRange(steps[stepValue - coinValues[cvIndex]].CoinValues);
                            //stepCoinValues.Add(coinValues[cvIndex]);
                            steps[stepValue].MinAmountCoins = tempMinAmountCoins;
                            steps[stepValue].CoinValues.Clear();
                            steps[stepValue].CoinValues.AddRange(steps[stepValue - coinValues[cvIndex]].CoinValues);
                            steps[stepValue].CoinValues.Add(coinValues[cvIndex]);
                        }
                    }
                }
               // steps[stepValue].MinAmountCoins = minimumAmountCoins;
               // steps[stepValue].CoinValues = stepCoinValues;
            }
            return steps[desiredValue].CoinValues;
        }

        private class StepInfo
        {
            public int? MinAmountCoins { get; set; }
            public List<int> CoinValues { get; set; }

            public StepInfo()
            {
                MinAmountCoins = null;
                CoinValues = new List<int>();
            }
        }
    }
}
