using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P623_AddOneRowtoTree;
using System.Collections.Generic;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P623_AddOneRowtoTree
    {
        protected readonly Solution _solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {

            var root = TreeNode.BuildTreeNode(new List<int?>() { 4, 2, 6, 3, 1, 5 });
            var result = _solution.AddOneRow(root, 1, 2);
            var ans = TreeNode.BuildTreeNode(new List<int?>() { 4, 1, 1, 2, null, null, 6, 3, 1, null, null, null, null, 5 });
            Assert.IsTrue(TreeNode.IsSameTree(result, root));
        }

        [TestMethod]
        public void TestMethod2()
        {

            var root = TreeNode.BuildTreeNode(new List<int?>() { 4, 2, null,3,1 });
            var result = _solution.AddOneRow(root, 1, 3);
            var ans = TreeNode.BuildTreeNode(new List<int?>() { 4, 2, null, 1, 1, null, null, 3, null, null, 1 });
            Assert.IsTrue(TreeNode.IsSameTree(result, root));
        }
    }
}
