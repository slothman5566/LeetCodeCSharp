using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P098_ValidateBinarySearchTree;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P098_ValidateBinarySearchTree
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(_Solution.IsValidBST(TreeNode.BuildTreeNode(new System.Collections.Generic.List<int?>() { 2, 1, 3 })));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsFalse(_Solution.IsValidBST(TreeNode.BuildTreeNode(new System.Collections.Generic.List<int?>() { 5, 1, 4, null, null, 3, 6 })));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsFalse(_Solution.IsValidBST(TreeNode.BuildTreeNode(new System.Collections.Generic.List<int?>() { 5, 2, 6, 1, 3, 4, 7 })));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsFalse(_Solution.IsValidBST(TreeNode.BuildTreeNode(new System.Collections.Generic.List<int?>() {1,1,null})));
        }

    }
}
