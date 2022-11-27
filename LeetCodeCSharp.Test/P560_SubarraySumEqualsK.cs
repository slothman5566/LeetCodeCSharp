using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P560_SubarraySumEqualsK;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P560_SubarraySumEqualsK
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2, _Solution.SubarraySum(new int[] { 1, 1, 1 }, 2));
        }
    }
}
