using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P226_InvertBinaryTree;
using System.Collections.Generic;
using System.Linq;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P226_InvertBinaryTree
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            var sourceNode = BuildTreeNode(new List<int>() { 4, 2, 7, 1, 3, 6, 9 });

            var newList = new List<int>();
            var resultList = new List<int>() { 7, 2, 9, 6, 3, 1 };

            ConvertTreeNodeToList(_Solution.InvertTree(sourceNode), newList);
            CollectionAssert.AreEqual(resultList, newList);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var sourceNode = BuildTreeNode(new List<int>() { 2, 1, 3 });

            var newList = new List<int>();
            var resultList = new List<int>() { 3, 1 };

            ConvertTreeNodeToList(_Solution.InvertTree(sourceNode), newList);
            CollectionAssert.AreEqual(resultList, newList);
        }


        protected TreeNode BuildTreeNode(List<int> list)
        {
            var node = list.Select(x =>
            {
                if (x == -1)
                {
                    return null;
                }
                return new TreeNode(x);
            }).ToList();

            var depth = 0;
            var count = 0;
            for (var i = 0; i < node.Count; i++)
            {
                if (i > count)
                {
                    depth++;
                    count += (int)Math.Pow(2, depth);
                    if (count == node.Count - 1)
                    {
                        break;
                    }

                }
                var temp = (int)Math.Pow(2, depth);
                node[i].left = node[i * 2 + 1];
                node[i].right = node[i * 2 + 2];


            }
            return node.First();
        }

        protected void ConvertTreeNodeToList(TreeNode node, List<int> list)
        {
            if (node == null)
            {
                return;
            }
            if (node.left != null)
            {
                list.Add(node.left.val);
            }
            if (node.right != null)
            {
                list.Add(node.right.val);
            }
            ConvertTreeNodeToList(node.left, list);
            ConvertTreeNodeToList(node.right, list);



        }
        //protected bool CheckedTreeNodeEqual()
        //{

        //}
    }
}
