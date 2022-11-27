using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P424_LongestRepeatingCharacterReplacement;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P424_LongestRepeatingCharacterReplacement
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(_Solution.CharacterReplacement("ABAB", 2),4);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(_Solution.CharacterReplacement("AABABBA", 1), 4);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(_Solution.CharacterReplacement("AAABBA", 2), 6);
        }
    }
}
