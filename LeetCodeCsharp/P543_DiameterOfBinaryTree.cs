using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P543_DiameterOfBinaryTree
{
    public class Solution
    {
        protected int _MaxDepth;
        public int DiameterOfBinaryTree(TreeNode root)
        {
            _MaxDepth = 0;
            GetDepth(root);
            return _MaxDepth;
        }
        protected int GetDepth(TreeNode node)
        {

            if (node == null)
            {
                return 0;
            }

            var left = GetDepth(node.left);
            var right = GetDepth(node.right);
            _MaxDepth = Math.Max(_MaxDepth, left + right);
            return Math.Max(left, right) + 1;
        }
    }
}
