using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P104_MaximumDepthOfBinaryTree;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P104_MaximumDepthOfBinaryTree
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, _Solution.MaxDepth(TreeNode.BuildTreeNode(new System.Collections.Generic.List<int?>() { 3, 9, 20, null, null, 15, 7 })));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(2, _Solution.MaxDepth(TreeNode.BuildTreeNode(new System.Collections.Generic.List<int?>() { 1, null, 2 })));
        }
    }
}
