using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P009_PalindromeNumber;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P009_PalindromeNumber
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(_Solution.IsPalindrome(121));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsFalse(_Solution.IsPalindrome(-121));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsFalse(_Solution.IsPalindrome(10));
        }
    }
}
