using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P024_SwapNodesInPairs;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P024_SwapNodesInPairs
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
          var result=  _Solution.SwapPairs(ListNode.BuildListNode(new System.Collections.Generic.List<int>() { 1, 2, 3, 4 }));
         CollectionAssert.AreEqual(new int[] { 2,1,4,3},   ListNode.ConvertListNodeToList(result));
        }
        [TestMethod]
        public void TestMethod2()
        {
            var result = _Solution.SwapPairs(ListNode.BuildListNode(new System.Collections.Generic.List<int>() { 1, 2, 3, 4,5 }));
            CollectionAssert.AreEqual(new int[] { 2, 1, 4, 3 ,5}, ListNode.ConvertListNodeToList(result));
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = _Solution.SwapPairs(ListNode.BuildListNode(new System.Collections.Generic.List<int>() { 1, 2 }));
            CollectionAssert.AreEqual(new int[] { 2, 1}, ListNode.ConvertListNodeToList(result));
        }
    }
}
