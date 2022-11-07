using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P300_LongestIncreasingSubsequence;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P300_LongestIncreasingSubsequence
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(4, _Solution.LengthOfLIS(new int[] { 10, 9, 2, 5, 3, 7, 101, 18 }));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(4, _Solution.LengthOfLIS(new int[] { 0, 1, 0, 3, 2, 3 }));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(1, _Solution.LengthOfLIS(new int[] { 7, 7, 7, 7, 7, 7, 7 }));
        }
        
    }
}
