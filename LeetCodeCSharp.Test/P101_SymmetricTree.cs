using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P101_SymmetricTree;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P101_SymmetricTree
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {

            Assert.IsTrue(_Solution.IsSymmetric(TreeNode.BuildTreeNode(new System.Collections.Generic.List<int?>() { 1, 2, 2, 3, 4, 4, 3 })));
        }

        [TestMethod]
        public void TestMethod2()
        {

            Assert.IsFalse(_Solution.IsSymmetric(TreeNode.BuildTreeNode(new System.Collections.Generic.List<int?>() { 1, 2, 2, null, 3, null, 3 })));
        }

    }
}
