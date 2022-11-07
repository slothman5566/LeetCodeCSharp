using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P198_HouseRobber;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P198_HouseRobber
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(5, _Solution.Rob(new int[] { 1, 2, 4, 1 }));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(12, _Solution.Rob(new int[] { 2, 7, 9, 3, 1 }));
        }

    }
}
