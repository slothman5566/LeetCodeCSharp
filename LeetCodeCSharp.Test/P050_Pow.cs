using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P050_Pow;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P050_Pow
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1024, _Solution.MyPow(2, 10));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(9.261000000000001, _Solution.MyPow(2.1, 3));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(0.25, _Solution.MyPow(2, -2));
        }
    }
}
