using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P148_SortList;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P148_SortList
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            var result = ListNode.ConvertListNodeToList(_Solution.SortList(ListNode.BuildListNode(new System.Collections.Generic.List<int>() { 4, 2, 1, 3 })));
            CollectionAssert.AreEqual(result, new int[] { 1, 2, 3, 4 });
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = ListNode.ConvertListNodeToList(_Solution.SortList(ListNode.BuildListNode(new System.Collections.Generic.List<int>() { -1, 5, 3, 4, 0 })));
            CollectionAssert.AreEqual(result, new int[] { -1, 0, 3, 4, 5 });
        }
    }
}
