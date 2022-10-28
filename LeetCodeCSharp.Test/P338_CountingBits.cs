using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P338_CountingBits;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P338_CountingBits
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
        CollectionAssert.AreEqual(new int[] {0,1,1 } ,   _Solution.CountBits(2));
        }

        [TestMethod]
        public void TestMethod2()
        {
            CollectionAssert.AreEqual(new int[] { 0, 1, 1, 2, 1, 2 }, _Solution.CountBits(5));
        }
    }
}
