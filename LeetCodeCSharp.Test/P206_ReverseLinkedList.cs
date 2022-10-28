using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P206_ReverseLinkedList;
using System.Collections.Generic;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P206_ReverseLinkedList
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
        
            var result = _Solution.ReverseList(ListNode.BuildListNode(new List<int>() { 1, 2, 3, 4, 5 }));
            CollectionAssert.AreEqual(ListNode.ConvertListNodeToList(result), new List<int>() { 5,4,3,2,1 });
        }

        [TestMethod]
        public void TestMethod2()
        {

            var result = _Solution.ReverseList(ListNode.BuildListNode(new List<int>() { 1, 2}));
            CollectionAssert.AreEqual(ListNode.ConvertListNodeToList(result), new List<int>() {  2, 1 });
        }
    }
}
