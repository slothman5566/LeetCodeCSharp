using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P014_LongestCommonPrefix;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P014_LongestCommonPrefix
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
          Assert.AreEqual("fl",  _Solution.LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("", _Solution.LongestCommonPrefix(new string[] { "dog", "racecar", "car" }));
           
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("c", _Solution.LongestCommonPrefix(new string[] { "cir", "car" }));

        }

    }
}
