using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P394_DecodeString;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P394_DecodeString
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new Solution();
          var result=  sol.DecodeString("3[a]2[bc]");
            Assert.AreEqual("aaabcbc", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var sol = new Solution();
            var result = sol.DecodeString("2[abc]3[cd]ef");
            Assert.AreEqual("abcabccdcdcdef", result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var sol = new Solution();
            var result = sol.DecodeString("3[a2[c]]");
            Assert.AreEqual("accaccacc", result);
        }
    }
}
