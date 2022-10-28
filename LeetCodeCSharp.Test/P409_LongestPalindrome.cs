using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P409_LongestPalindrome;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P409_LongestPalindrome
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
          var a=  _Solution.LongestPalindrome("abccccdd");
        }
    }
}
