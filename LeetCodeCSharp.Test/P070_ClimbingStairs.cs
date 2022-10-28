using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P070_ClimbingStairs;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P070_ClimbingStairs
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(_Solution.ClimbStairs(3), 3);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual( _Solution.ClimbStairs(8),34);
        }
    }
}
