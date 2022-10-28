using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P191_NumberOf1Bits;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P191_NumberOf1Bits
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, _Solution.HammingWeight(0b_00000000000000000000000000001011));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(1, _Solution.HammingWeight(0b_00000000000000000000000010000000));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(31, _Solution.HammingWeight(0b_11111111111111111111111111111101));
        }
    }
}
