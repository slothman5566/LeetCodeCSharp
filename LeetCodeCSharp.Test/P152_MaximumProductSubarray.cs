using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P152_MaximumProductSubarray;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P152_MaximumProductSubarray
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new Solution();
            Assert.AreEqual(6, sol.MaxProduct(new int[] { 2, 3, -2, 4 }));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var sol = new Solution();
            Assert.AreEqual(0, sol.MaxProduct(new int[] { -2, 0,-2 }));
        }

        [TestMethod]
        public void TestMethod3()
        {
            var sol = new Solution();
            Assert.AreEqual(24, sol.MaxProduct(new int[] { -2, 3,-4 }));
        }
    }
}
