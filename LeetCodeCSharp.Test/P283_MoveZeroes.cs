using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P283_MoveZeroes;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P283_MoveZeroes
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            var nums = new int[] { 0, 1, 0, 3, 12 };
            _Solution.MoveZeroes(nums);
          CollectionAssert.AreEqual(new int[] { 1,3,12,0,0}, nums );
        }
    }
}
