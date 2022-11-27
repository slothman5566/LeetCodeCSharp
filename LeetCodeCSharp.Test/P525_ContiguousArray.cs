using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P525_ContiguousArray;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P525_ContiguousArray
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new Solution();
            Assert.AreEqual(2, sol.FindMaxLength(new int[] { 0, 1, 0 }));
        }
    }
}
