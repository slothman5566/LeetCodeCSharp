using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P075_SortColors;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P075_SortColors
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            var nums = new int[] { 2, 0, 2, 1, 1, 0 };
            _Solution.SortColors(nums);
            CollectionAssert.AreEqual(new int[] { 0, 0, 1, 1, 2, 2 }, nums);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var nums = new int[] { 2, 0, 1 };
            _Solution.SortColors(nums);
            CollectionAssert.AreEqual(new int[] { 0,1,2 }, nums);
        }
    }
}
