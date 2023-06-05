using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P026_RemoveDuplicatesFromSortedArray;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P026_RemoveDuplicatesFromSortedArray
    {
        
       protected readonly Solution _Solution=new Solution();
        [TestMethod]
        public void TestMethod1()
        {
           var result= _Solution.RemoveDuplicates(new int[] { 1,1, 2, });
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var result = _Solution.RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });
            Assert.AreEqual(5, result);
        }
    }
}
