using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CalculatorFramework;

namespace CalculatorFramework.Tests
{
    [TestClass]
    public class CalculatorServicesTests
    {
        [TestMethod]
        public void TokenizeCharacters_ValidResult()
        {
            char[] verifiedParsedInput = {
                '1',
                '0',
                '*',
                '.',
                '1',
                '-',
                '2'
            };
            List<string> expected = new List<string> {
                "10"
                ,"*"
                ,".1"
                ,"-"
                ,"2"
            };
            CalculatorServices _calc = new CalculatorServices();
            List<string> actual = _calc.TokenizeCharacters(verifiedParsedInput);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
