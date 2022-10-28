using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P125_ValidPalindrome;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P125_ValidPalindrome
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(_Solution.IsPalindrome("A man, a plan, a canal: Panama"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsFalse(_Solution.IsPalindrome("race a car"));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(_Solution.IsPalindrome(" "));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsFalse(_Solution.IsPalindrome("0P"));
        }
        
    }
}
