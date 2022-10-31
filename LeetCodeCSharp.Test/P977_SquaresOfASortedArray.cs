using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P977_SquaresOfASortedArray;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P977_SquaresOfASortedArray
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            CollectionAssert.AreEqual(new int[] { 0, 1, 9, 16, 100 }, _Solution.SortedSquares(new int[] { -4, -1, 0, 3, 10 }));
        }
    }
}
