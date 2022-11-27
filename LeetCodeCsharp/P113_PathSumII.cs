using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P113_PathSumII
{
    public class Solution
    {
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            var result = new List<IList<int>>();
            var list = new List<int>();
            DFS(root, targetSum, list, result);
            return result;
        }

        void DFS(TreeNode treeNode,int targetSum,List<int> list, List<IList<int>> result)
        {
            if (treeNode == null)
            {
                return;
            }
            list.Add(treeNode.val);
            if(targetSum== treeNode.val && treeNode.left==null && treeNode.right == null)
            {
                result.Add(list.ToList());
            }
            DFS(treeNode.left, targetSum - treeNode.val, list, result);
            DFS(treeNode.right, targetSum - treeNode.val, list, result);
            list.RemoveAt(list.Count - 1);
        }
    }
}
