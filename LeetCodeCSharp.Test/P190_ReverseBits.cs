using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P190_ReverseBits;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P190_ReverseBits
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0b_10111111111111111111111111111111, _Solution.reverseBits(0b_11111111111111111111111111111101));
        }


        //[TestMethod]
        //public void TestMethod2()
        //{
        //    Assert.AreEqual(0b_00111001011110000010100101000000, _Solution.reverseBits(0b_00000010100101000001111010011100));
        //}
    }
}
