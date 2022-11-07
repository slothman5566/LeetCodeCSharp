using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P062_UniquePaths;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P062_UniquePaths
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, _Solution.UniquePaths(3, 2));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(3, _Solution.UniquePaths(2, 3));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(28, _Solution.UniquePaths(7, 3));
        }
    }
}
