using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P623_AddOneRowtoTree

{
    public class Solution
    {
        public TreeNode AddOneRow(TreeNode root, int val, int depth)
        {
            if (root == null) return null;
            if (depth == 1)
            {
                var node = new TreeNode(val);
                node.left = root;
                return node;
            }
            if (depth == 2)
            {
                var left = root.left;
                root.left = new TreeNode(val);
                root.left.left = left;

                var right = root.right;
                root.right = new TreeNode(val);
                root.right.right = right;
            }
            else
            {
                AddOneRow(root.left, val, depth - 1);
                AddOneRow(root.right, val, depth - 1);
              
            }
            return root;
        }
    }
}
