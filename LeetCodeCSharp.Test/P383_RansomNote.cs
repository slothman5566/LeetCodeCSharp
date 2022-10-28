using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P383_RansomNote;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P383_RansomNote
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsFalse(_Solution.CanConstruct("a", "b"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsFalse(_Solution.CanConstruct("aa", "ab"));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(_Solution.CanConstruct("aa", "aab"));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsTrue(_Solution.CanConstruct("aab", "baa"));
        }
    }
}
