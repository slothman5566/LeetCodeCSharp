using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P104_MaximumDepthOfBinaryTree
{
    public class Solution
    {
       

        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var left = MaxDepth(root.left);
            var right = MaxDepth(root.right);

            return Math.Max(left, right) + 1;
        }
       
    }
}
