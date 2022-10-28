using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P217_ContainsDuplicate;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P217_ContainsDuplicate
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(_Solution.ContainsDuplicate(new int[] {1,2,3,1 }));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsFalse(_Solution.ContainsDuplicate(new int[] { 1, 2, 3, 4 }));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(_Solution.ContainsDuplicate(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }));
        }

    }
}
