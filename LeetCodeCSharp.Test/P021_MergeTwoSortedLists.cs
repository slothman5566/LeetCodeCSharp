using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P021_MergeTwoSortedLists;
namespace LeetCodeCSharp.Test
{

    [TestClass]
    public class P021_MergeTwoSortedLists
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
        
            var node1 = BuildListNode(new int[] { 1,2,4 });
            var node2 = BuildListNode(new int[] { 1, 3, 4 });
        
            Assert.IsTrue(CheckMergeTwoSortedLists(_Solution.MergeTwoLists(node1, node2), BuildListNode(new int[] { 1, 1, 2, 3, 4, 4 })));
        }


        [TestMethod]
        public void TestMethod2()
        {

            var node1 = BuildListNode(new int[] { });
            var node2 = BuildListNode(new int[] { });
           

            Assert.IsTrue(CheckMergeTwoSortedLists(_Solution.MergeTwoLists(node1, node2), BuildListNode(new int[] {  })));
        }


        [TestMethod]
        public void TestMethod3()
        {

            var node1 = BuildListNode(new int[] { });
            var node2 = BuildListNode(new int[] {0 });


            Assert.IsTrue(CheckMergeTwoSortedLists(_Solution.MergeTwoLists(node1, node2), BuildListNode(new int[] { 0})));
        }

        [TestMethod]
        public void TestMethod4()
        {

            var node1 = BuildListNode(new int[] { 1,1});
            var node2 = BuildListNode(new int[] { 2,3,4,5 });


            Assert.IsTrue(CheckMergeTwoSortedLists(_Solution.MergeTwoLists(node1, node2), BuildListNode(new int[] { 1,1,2,3,4,5})));
        }



        protected ListNode BuildListNode(int[] array)
        {
            if (array.Length == 0)
            {
                return null;
            }
            var node = new ListNode();
            ListNode curNode = node;
            for(var i=0; i < array.Length; i++)
            {
                curNode.val = array[i];
                if (i != array.Length - 1)
                {
                    var newNode = new ListNode();
                    curNode.next = newNode;
                    curNode = newNode;
                }
               
            }
          
            return node;
        }

        protected bool CheckMergeTwoSortedLists(ListNode source, ListNode target)
        {

            while (source != null && target != null)
            {

                if (source.val != target.val)
                {
                    return false;
                }

                source = source.next;
                target = target.next;

            }
            return true;
        }


    }
}
