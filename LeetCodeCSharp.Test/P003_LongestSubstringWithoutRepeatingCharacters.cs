using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P003_LongestSubstringWithoutRepeatingCharacters;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P003_LongestSubstringWithoutRepeatingCharacters
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, _Solution.LengthOfLongestSubstring("abcabcbb"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(1, _Solution.LengthOfLongestSubstring("bbbbb"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(3, _Solution.LengthOfLongestSubstring("pwwkew"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(2, _Solution.LengthOfLongestSubstring("abba"));
        }
    }
}
