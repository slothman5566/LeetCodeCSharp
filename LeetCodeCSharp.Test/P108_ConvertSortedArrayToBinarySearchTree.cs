using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P108_ConvertSortedArrayToBinarySearchTree;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P108_ConvertSortedArrayToBinarySearchTree
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
      

            Assert.IsTrue(TreeNode.IsSameTree(_Solution.SortedArrayToBST(new int[] { -10, -3, 0, 5, 9 }),
                TreeNode.BuildTreeNode(new System.Collections.Generic.List<int?>() { 0, -3, 9, -10, null, 5 , null })));
        }

        [TestMethod]
        public void TestMethod2()
        {


            Assert.IsTrue(TreeNode.IsSameTree(_Solution.SortedArrayToBST(new int[] { 1,3}),
                TreeNode.BuildTreeNode(new System.Collections.Generic.List<int?>() { 3,1, null })));
        }

    }
}
