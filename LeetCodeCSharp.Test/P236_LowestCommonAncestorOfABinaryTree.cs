using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P236_LowestCommonAncestorOfABinaryTree;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P236_LowestCommonAncestorOfABinaryTree
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            var root = TreeNode.BuildTreeNode(new System.Collections.Generic.List<int?>() { 3, 5, 1, 6, 2, 0, 8, null, null, 7, 4 });
            var left = root.left;
            var right = root.right.right;
            Assert.AreEqual(root, _Solution.LowestCommonAncestor(root, left, right));
        }
    }
}
