using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P100_SameTree;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P100_SameTree
    {
        Solution _Solution = new Solution();
        

        [TestMethod]
        public void TestMethod1()
        {
           Assert.IsTrue( _Solution.IsSameTree(TreeNode.BuildTreeNode(new System.Collections.Generic.List<int?>() {1,2,3 }),
                TreeNode.BuildTreeNode(new System.Collections.Generic.List<int?>() {1,2,3 })));
        }
    }
}
