using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P136_SingleNumber;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P136_SingleNumber
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, _Solution.SingleNumber(new int[] { 2,2,1}));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(4, _Solution.SingleNumber(new int[] { 4, 1, 2, 1, 2 }));
        }
    }
}
