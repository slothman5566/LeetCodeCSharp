using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using LeetCodeCSharp.P110_BalancedBinaryTree;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P110_BalancedBinaryTree
    {
        Solution _Solution = new Solution();

        [TestMethod]
        public void TestMethod1()
        {
            var node =TreeNode.BuildTreeNode(new List<int?>() { 3, 9, 20, null, null, 15, 7 });
            Assert.IsTrue(_Solution.IsBalanced(node));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var node = TreeNode.BuildTreeNode(new List<int?>() { 1,2,2,3,3, null, null,4,4 });
            Assert.IsFalse(_Solution.IsBalanced(node));
        }

    
    }
}
