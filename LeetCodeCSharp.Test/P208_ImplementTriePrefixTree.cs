using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P208_ImplementTriePrefixTree;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P208_ImplementTriePrefixTree
    {
        [TestMethod]
        public void TestMethod1()
        {
            Trie trie = new Trie();
            trie.Insert("apple");
            Assert.IsTrue(trie.Search("apple"));   // return True
            Assert.IsFalse(trie.Search("app"));     // return False
            Assert.IsTrue(trie.StartsWith("app")); // return True
            trie.Insert("app");
            Assert.IsTrue(trie.Search("app"));     // return True
        }
    }
}
