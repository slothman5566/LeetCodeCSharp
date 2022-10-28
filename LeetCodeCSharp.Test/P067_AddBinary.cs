using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P067_AddBinary;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P067_AddBinary
    {
        Solution Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("100", Solution.AddBinary("11", "1"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("10101", Solution.AddBinary("1010", "1011"));
        }
    }
}
