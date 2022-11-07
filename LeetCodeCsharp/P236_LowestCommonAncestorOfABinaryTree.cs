using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P236_LowestCommonAncestorOfABinaryTree
{
    public class Solution
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || root == p || root == q) return root;
            var l = LowestCommonAncestor(root.left, p, q);
            var r = LowestCommonAncestor(root.right, p, q);
            if (l == null || r == null) return l == null ? r : l;
            return root;
        }
    }
}
