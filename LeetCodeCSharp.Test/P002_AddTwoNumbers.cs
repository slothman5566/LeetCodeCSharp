using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P002_AddTwoNumbers;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P002_AddTwoNumbers
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            //test
            var node1 = ListNode.BuildListNode(new System.Collections.Generic.List<int>() { 2, 4, 3 });
            var nodd2 = ListNode.BuildListNode(new System.Collections.Generic.List<int>() { 5,6,4 });
         var result=   _Solution.AddTwoNumbers(node1, nodd2);
          CollectionAssert.AreEqual(new int[] { 7,0,8},  ListNode.ConvertListNodeToList(result));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var node1 = ListNode.BuildListNode(new System.Collections.Generic.List<int>() { 9, 9, 9, 9, 9, 9, 9 });
            var nodd2 = ListNode.BuildListNode(new System.Collections.Generic.List<int>() { 9, 9, 9, 9 });
            var result = _Solution.AddTwoNumbers(node1, nodd2);
            CollectionAssert.AreEqual(new int[] { 8, 9, 9, 9, 0, 0, 0, 1 }, ListNode.ConvertListNodeToList(result));
        }

        [TestMethod]
        public void TestMethod3()
        {
            var node1 = ListNode.BuildListNode(new System.Collections.Generic.List<int>() { 0 });
            var nodd2 = ListNode.BuildListNode(new System.Collections.Generic.List<int>() { 0 });
            var result = _Solution.AddTwoNumbers(node1, nodd2);
            CollectionAssert.AreEqual(new int[] { 0 }, ListNode.ConvertListNodeToList(result));
        }

        [TestMethod]
        public void TestMethod4()
        {
            var node1 = ListNode.BuildListNode(new System.Collections.Generic.List<int>() {9});
            var nodd2 = ListNode.BuildListNode(new System.Collections.Generic.List<int>() { 1, 9, 9, 9, 9, 9, 9, 9, 9, 9 });
            var result = _Solution.AddTwoNumbers(node1, nodd2);
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 }, ListNode.ConvertListNodeToList(result));
        }

    }
}
