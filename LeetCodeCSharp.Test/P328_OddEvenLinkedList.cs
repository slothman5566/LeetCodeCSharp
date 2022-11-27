using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P328_OddEvenLinkedList;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P328_OddEvenLinkedList
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
           var result= ListNode.ConvertListNodeToList( _Solution.OddEvenList(ListNode.BuildListNode(new System.Collections.Generic.List<int>() { 1, 2, 3, 4, 5 })));
       
        }
    }
}
