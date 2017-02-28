using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public class LCS
    {
        public string Word1 { get; set; }
        public string Word2 { get; set; }

        public LCS(string word1 = "quetzalcoatl", string word2 = "tezcatlipoca")
        {
            Word1 = word1;
            Word2 = word2;
        }

        public void CalcLongestCommonSequence()
        {
            int W1Length = Word1.Length + 1;
            int W2Length = Word2.Length + 1;

            char[] W1Chars = new char[W1Length];
            char[] W2Chars=  new char[W2Length];

            int[][] LCS = new int[W1Length][];
        }
    }
}
