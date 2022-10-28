using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P013_RomanToInteger;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P013_RomanToInteger
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, _Solution.RomanToInt("III"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(58, _Solution.RomanToInt("LVIII"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(1994, _Solution.RomanToInt("MCMXCIV"));
        }

    }
}
