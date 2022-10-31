using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P238_ProductOfArrayExceptSelf;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P238_ProductOfArrayExceptSelf
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
        CollectionAssert.AreEqual(new int[] { 24,12,8,6},    _Solution.ProductExceptSelf(new int[] { 1,2,3,4}));
        }
    }
}
