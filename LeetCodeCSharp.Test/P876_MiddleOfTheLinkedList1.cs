using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P876_MiddleOfTheLinkedList;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P876_MiddleOfTheLinkedList
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
          var node=  _Solution.MiddleNode(ListNode.BuildListNode(new System.Collections.Generic.List<int>() { 1, 2, 3, 4, 5 }));
            Assert.AreEqual(3, node.val);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var node = _Solution.MiddleNode(ListNode.BuildListNode(new System.Collections.Generic.List<int>() { 1, 2, 3, 4, 5 ,6}));
            Assert.AreEqual(4, node.val);
        }
    }
}
