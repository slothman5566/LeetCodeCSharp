using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P005_LongestPalindromicSubstring;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P005_LongestPalindromicSubstring
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
           
            Assert.AreEqual("bab", _Solution.LongestPalindrome("babad"));
        }

        [TestMethod]
        public void TestMethod2()
        {

            Assert.AreEqual("bb", _Solution.LongestPalindrome("cbbd"));
        }
    }
}
