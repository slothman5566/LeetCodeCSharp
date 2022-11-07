using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P416_PartitionEqualSubsetSum;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P416_PartitionEqualSubsetSum
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(_Solution.CanPartition(new int[] { 1, 5, 11, 5 }));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsFalse(_Solution.CanPartition(new int[] { 1, 5, 5,3 }));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(_Solution.CanPartition(new int[] { 1, 5, 5, 3,2 }));
        }
    }
}
