using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P287_FindTheDuplicateNumber;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P287_FindTheDuplicateNumber
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
           Assert.AreEqual(2, _Solution.FindDuplicate(new int[] { 1,3,4,2,2}));

        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(3, _Solution.FindDuplicate(new int[] { 1, 3, 4, 3, 2 }));

        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(2, _Solution.FindDuplicate(new int[] { 2,2,2,2,2 }));

        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(1, _Solution.FindDuplicate(new int[] { 1, 1, 1, 1, 1 }));

        }
    }
}
