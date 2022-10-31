using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P001_TwoSum;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P001_TwoSum
    {
        protected Solution _Solution = new Solution();


        [TestMethod]
        public void TestMethod1()
        {
        
            CollectionAssert.AreEqual(_Solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9), new int[] { 0, 1 });
        }

        [TestMethod]
        public void TestMethod2()
        {
            CollectionAssert.AreEqual(_Solution.TwoSum(new int[] { 3, 2, 4 }, 5), new int[] { 0,1 });

        }

        [TestMethod]
        public void TestMethod3()
        {
            CollectionAssert.AreEqual(_Solution.TwoSum(new int[] { 3,3 }, 6), new int[] { 0, 1 });

        }

        [TestMethod]
       
           public void TestMethod4()
        {
            CollectionAssert.AreEqual(_Solution.TwoSum(new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11), new int[] { 5,11 });

        }
    }
}
