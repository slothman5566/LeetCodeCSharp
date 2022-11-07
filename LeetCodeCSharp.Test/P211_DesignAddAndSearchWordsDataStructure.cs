using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P211_DesignAddAndSearchWordsDataStructure;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P211_DesignAddAndSearchWordsDataStructure
    {
        [TestMethod]
        public void TestMethod1()
        {
            WordDictionary wordDictionary = new WordDictionary();
            wordDictionary.AddWord("bad");
            wordDictionary.AddWord("dad");
            wordDictionary.AddWord("mad");
            Assert.IsFalse(wordDictionary.Search("pad")); // return False
            Assert.IsTrue(wordDictionary.Search("bad")); // return True
            Assert.IsTrue(wordDictionary.Search(".ad")); // return True
            Assert.IsTrue(wordDictionary.Search("b..")); // return True
        }
    }
}
