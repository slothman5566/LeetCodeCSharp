using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P121_BestTimetoBuyandSellStock;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P121_BestTimetoBuyandSellStock
    {
        protected Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(_Solution.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 }), 5);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(_Solution.MaxProfit(new int[] { 7, 6, 5, 4, 3, 2 }), 0);
        }
    }
}
