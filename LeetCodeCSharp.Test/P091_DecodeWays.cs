using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P091_DecodeWays;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P091_DecodeWays
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
         Assert.AreEqual(2,   _Solution.NumDecodings("12"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(3, _Solution.NumDecodings("226"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(0, _Solution.NumDecodings("06"));
        }
    }
}
