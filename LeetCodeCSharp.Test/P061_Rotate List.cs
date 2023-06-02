using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P061_RotateList;
using System.Collections.Generic;

namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P061_Rotate_List
    {

        protected Solution _Solution = new Solution();


        [TestMethod]
        public void TestMethod1()
        {
            var result = _Solution.RotateRight(ListNode.BuildListNode(new List<int> { 1, 2, 3, 4, 5 }), 2);
            //test
            CollectionAssert.AreEqual(ListNode.ConvertListNodeToList(result), new List<int>() { 4, 5, 1, 2, 3 });
        }


        [TestMethod]
        public void TestMethod2()
        {
            var result = _Solution.RotateRight(ListNode.BuildListNode(new List<int> { 0, 1, 2 }), 4);
            //test
            CollectionAssert.AreEqual(ListNode.ConvertListNodeToList(result), new List<int>() { 2, 0, 1 });
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = _Solution.RotateRight(null, 4);
            //test
            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            ///time limit error
            var result = _Solution.RotateRight(ListNode.BuildListNode(new List<int> { 1,2,3 }), 2000000000);
            //test
            CollectionAssert.AreEqual(ListNode.ConvertListNodeToList(result), new List<int>() { 2,3,1});
        }
    }
}
