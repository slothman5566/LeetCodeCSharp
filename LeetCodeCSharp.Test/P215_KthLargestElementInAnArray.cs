using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P215_KthLargestElementInAnArray;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P215_KthLargestElementInAnArray
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(5, _Solution.FindKthLargest(new int[] { 3, 2, 1, 5, 6, 4 }, 2));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(4, _Solution.FindKthLargest(new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4));
        }
    }
}
