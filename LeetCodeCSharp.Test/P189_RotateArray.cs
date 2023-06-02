using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P189_RotateArray;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P189_RotateArray
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            var nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            _Solution.Rotate(nums, 3);
            CollectionAssert.AreEqual(nums, new int[] { 5, 6, 7, 1, 2, 3, 4 });
        }
    }
}
