using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P268_MissingNumber;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P268_MissingNumber
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2, _Solution.MissingNumber(new int[] {3,0,1 }));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(2, _Solution.MissingNumber(new int[] {  0, 1 }));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(8, _Solution.MissingNumber(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }));
        }

    }
}
