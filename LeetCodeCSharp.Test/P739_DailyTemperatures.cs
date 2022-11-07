using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P739_DailyTemperatures;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P739_DailyTemperatures
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            CollectionAssert.AreEqual(new int[] { 1, 1, 4, 2, 1, 1, 0, 0 }, _Solution.DailyTemperatures(new int[] { 73, 74, 75, 71, 69, 72, 76, 73 }));
        }

        [TestMethod]
        public void TestMethod2()
        {
            CollectionAssert.AreEqual(new int[] { 1,1,1,0}, _Solution.DailyTemperatures(new int[] { 30, 40, 50, 60 }));
        }
        [TestMethod]
        public void TestMethod3()
        {
            CollectionAssert.AreEqual(new int[] { 1, 1, 0 }, _Solution.DailyTemperatures(new int[] { 30, 40, 50 }));
        }
    }
}
