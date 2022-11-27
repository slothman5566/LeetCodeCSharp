using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P128_LongestConsecutiveSequence;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P128_LongestConsecutiveSequence
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(4, _Solution.LongestConsecutive(new int[] { 100, 4, 200, 1, 3, 2 }));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(9, _Solution.LongestConsecutive(new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }));
        }
    }
}
