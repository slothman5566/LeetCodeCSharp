using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P053_MaximumSubarray;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P053_MaximumSubarray
    {
        Solution2 _Solution2= new Solution2();
        Solution1 _Solution1 = new Solution1();
        [TestMethod]
        public void TestMethod1()
        {
            var nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Assert.AreEqual(6, _Solution1.MaxSubArray(nums));
            Assert.AreEqual(6, _Solution2.MaxSubArray(nums));
        }
        [TestMethod]
        public void TestMethod2()
        {
            var nums = new int[] { 1 };
            Assert.AreEqual(1, _Solution1.MaxSubArray(nums));
            Assert.AreEqual(1, _Solution2.MaxSubArray(nums));
        }

        [TestMethod]
        public void TestMethod3()
        {
            var nums = new int[] { 5, 4, -1, 7, 8 };
            Assert.AreEqual(23, _Solution1.MaxSubArray(nums));
            Assert.AreEqual(23, _Solution2.MaxSubArray(nums));
        }
    }
}
