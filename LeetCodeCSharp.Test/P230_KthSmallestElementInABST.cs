using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P230_KthSmallestElementInABST;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P230_KthSmallestElementInABST
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
          Assert.AreEqual(1,  _Solution.KthSmallest(TreeNode.BuildTreeNode(new System.Collections.Generic.List<int?>() { 3, 1, 4, null, 2 }),1));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(3, _Solution.KthSmallest(TreeNode.BuildTreeNode(new System.Collections.Generic.List<int?>() { 5, 3, 6, 2, 4, null, null, 1 }), 3));
        }
    }
}
