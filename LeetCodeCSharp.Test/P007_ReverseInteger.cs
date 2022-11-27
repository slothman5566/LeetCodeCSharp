using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P007_ReverseInteger;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P007_ReverseInteger
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(321, _Solution.Reverse(123));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(-321, _Solution.Reverse(-123));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(21, _Solution.Reverse(120));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(0, _Solution.Reverse(1534236469));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(-2143847412, _Solution.Reverse(-2147483412));
        }
    }
}
