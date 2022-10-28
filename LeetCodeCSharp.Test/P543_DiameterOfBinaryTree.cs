using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P543_DiameterOfBinaryTree;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P543_DiameterOfBinaryTree
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
          Assert.AreEqual(3,  _Solution.DiameterOfBinaryTree(TreeNode.BuildTreeNode(new System.Collections.Generic.List<int?>() { 1, 2, 3, 4, 5 })));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(1, _Solution.DiameterOfBinaryTree(TreeNode.BuildTreeNode(new System.Collections.Generic.List<int?>() { 1, 2 ,null})));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(2, _Solution.DiameterOfBinaryTree(TreeNode.BuildTreeNode(new System.Collections.Generic.List<int?>() { 1, 2 ,3})));
        }


    }
}
