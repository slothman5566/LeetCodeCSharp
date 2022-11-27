using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P179_LargestNumber;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P179_LargestNumber
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
          Assert.AreEqual("210",  _Solution.LargestNumber(new int[] { 10, 2 }));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("9534330", _Solution.LargestNumber(new int[] { 3, 30, 34, 5, 9 }));
        }
    }
}
