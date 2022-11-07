using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P033_SearchInRotatedSortedArray;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P033_SearchInRotatedSortedArray
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(4, _Solution.Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(-1, _Solution.Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(-1, _Solution.Search(new int[] {2 }, 0));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(3, _Solution.Search(new int[] { 0, 1, 2,4, 5, 6, 7,  }, 4));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(2, _Solution.Search(new int[] {  6, 7, 0, 1, 2 , 4, 5, }, 0));
        }
    }
}
