using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P662_MaximumWidthOfBinaryTree;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P662_MaximumWidthOfBinaryTree
    {
        Solution _Solution = new Solution();

        [TestMethod]
        public void TestMethod1()
        {
            var root = TreeNode.BuildTreeNode(new System.Collections.Generic.List<int?>() { 1, 3, 2, 5, 3, null, 9 });
            Assert.AreEqual(4, _Solution.WidthOfBinaryTree(root));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var root = TreeNode.BuildTreeNode(new System.Collections.Generic.List<int?>() { 1, 3, 2, 5 });
            Assert.AreEqual(2, _Solution.WidthOfBinaryTree(root));
        }
    }
}
