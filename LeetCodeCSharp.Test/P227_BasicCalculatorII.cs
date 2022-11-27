using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P227_BasicCalculatorII;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P227_BasicCalculatorII
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(7, _Solution.Calculate("3+2*2"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(1, _Solution.Calculate("3/2"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(5, _Solution.Calculate("3+5/2"));
        }


    }
}
