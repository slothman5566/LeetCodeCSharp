using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P844_BackspaceStringCompare;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P844_BackspaceStringCompare
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(_Solution.BackspaceCompare("ab#c", "ad#c"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(_Solution.BackspaceCompare("ab##", "c#d#"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsFalse(_Solution.BackspaceCompare("a#c", "b"));
        }

    }
}
