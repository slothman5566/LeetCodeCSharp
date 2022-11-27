using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P055_JumpGame;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P055_JumpGame
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(_Solution.CanJump(new int[] { 2, 3, 1, 1, 4 }));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsFalse(_Solution.CanJump(new int[] { 3,2,1,0,4 }));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(_Solution.CanJump(new int[] {  0 }));
        }
    }
}
