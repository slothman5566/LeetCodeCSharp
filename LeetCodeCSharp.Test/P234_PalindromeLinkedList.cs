using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P234_PalindromeLinkedList;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P234_PalindromeLinkedList
    {
        [TestMethod]
        public void TestMethod1()
        {
            var solution = new Solution();

            Assert.IsTrue(solution.IsPalindrome(ListNode.BuildListNode(new System.Collections.Generic.List<int>() { 1,2,2,1})));
        }
    }
}
