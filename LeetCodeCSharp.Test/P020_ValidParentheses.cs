using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P020_ValidParentheses;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P020_ValidParentheses
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(_Solution.IsValid("()"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(_Solution.IsValid("()[]{}"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsFalse(_Solution.IsValid("(}"));
        }
    }
}
