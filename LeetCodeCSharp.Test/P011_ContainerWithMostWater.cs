using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P011_ContainerWithMostWater;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P011_ContainerWithMostWater
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
        Assert.AreEqual(49,    _Solution.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(1, _Solution.MaxArea(new int[] { 1, 1 }));
        }
    }
}
