using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using LeetCodeCSharp.P102_BinaryTreeLevelOrderTraversal;
using System.Collections.Generic;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P102_BinaryTreeLevelOrderTraversal
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            var root = TreeNode.BuildTreeNode(new List<int?>() { 3, 9, 20, null, null, 15, 7 });
            var ans = _Solution.LevelOrder(root);
            var result = new List<List<int>>();
            result.Add(new List<int>() { 3 });
            result.Add(new List<int>() { 9, 20 });
            result.Add(new List<int>() { 15, 7 });

            for(var i=0; i < result.Count; i++)
            {
                CollectionAssert.AreEqual(result[i], ans[i].ToList());
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            var root = TreeNode.BuildTreeNode(new List<int?>() { 1});
            var ans = _Solution.LevelOrder(root);
            var result = new List<List<int>>();
            result.Add(new List<int>() { 1 });
           

            for (var i = 0; i < result.Count; i++)
            {
                CollectionAssert.AreEqual(result[i], ans[i].ToList());
            }
        }

    }
}
