using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P572_SubtreeOfAnotherTree;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P572_SubtreeOfAnotherTree
    {
        Solution _Solution = new Solution();


        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(_Solution.IsSubtree(TreeNode.BuildTreeNode(new System.Collections.Generic.List<int?>() { 3,4,5,1,2 }),
                  TreeNode.BuildTreeNode(new System.Collections.Generic.List<int?>() { 4,1,2 }
                  )));
        }
    }
}
