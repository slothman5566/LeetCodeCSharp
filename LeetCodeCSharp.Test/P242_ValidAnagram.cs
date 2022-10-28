using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P242_ValidAnagram;
using System.Linq;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P242_ValidAnagram
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
    
            Assert.IsTrue(_Solution.IsAnagram("anagram", "nagaram"));
        }

        [TestMethod]
        public void TestMethod2()
        {

            Assert.IsFalse(_Solution.IsAnagram("rat", "car"));
        }
    }
}
