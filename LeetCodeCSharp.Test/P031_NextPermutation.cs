using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P031_NextPermutation;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P031_NextPermutation
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            var result = new int[] { 1, 2, 3 };
            _Solution.NextPermutation(result);
            CollectionAssert.AreEqual(new int[] { 1, 3, 2 }, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = new int[] { 1, 3, 2 };
            _Solution.NextPermutation(result);
            CollectionAssert.AreEqual(new int[] { 2, 1, 3 }, result);
        }
    }
}
