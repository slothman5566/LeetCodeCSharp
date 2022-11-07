using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P139_WordBreak;
using System.Collections.Generic;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P139_WordBreak
    {

        [TestMethod]
        public void TestMethod1()
        {
            var solution = new Solution();
            Assert.IsTrue(solution.WordBreak("leetcode", new List<string>() { "leet", "code" }));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var solution = new Solution();
            Assert.IsTrue(solution.WordBreak("applepenapple", new List<string>() { "apple", "pen" }));
        }

        [TestMethod]
        public void TestMethod3()
        {
            var solution = new Solution();
            Assert.IsFalse(solution.WordBreak("catsandog", new List<string>() { "cats", "dog", "sand", "and", "cat" }));
        }
    }
}
