using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P704_BinarySearch;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P704_BinarySearch
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            var nums = new int[] { -1, 0, 3, 5, 9, 12 };

            Assert.AreEqual(_Solution.Search(nums, 9), 4);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var nums = new int[] { -1, 0, 3, 5, 9, 12 };

            Assert.AreEqual(_Solution.Search(nums, 2), -1);
        }
    }
}
