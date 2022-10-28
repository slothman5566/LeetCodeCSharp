using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P169_MajorityElement;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P169_MajorityElement
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(_Solution.MajorityElement(new int[] { 3, 2, 3 }), 3);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(_Solution.MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 }), 2);
        }

    }
}
