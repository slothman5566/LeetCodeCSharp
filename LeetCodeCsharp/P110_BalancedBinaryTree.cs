using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P110_BalancedBinaryTree
{
    public class Solution
    {
        public bool IsBalanced(TreeNode root)
        {
            return Dfs(root)!=-1;
        }

        protected int Dfs(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            var left = Dfs(node.left);
            var right = Dfs(node.right);

            if(left==-1 || right ==-1 || Math.Abs(left - right) > 1)
            {
                return -1;
            }
            return 1 + Math.Max(left, right);
        }
    }

}
