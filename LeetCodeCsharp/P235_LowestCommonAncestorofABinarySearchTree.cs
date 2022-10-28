using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P235_LowestCommonAncestorofABinarySearchTree
{




    public class Solution
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (p.val > q.val)
            {
                return LCA(root, p, q);
            }
            return LCA(root, q, p);
           
        }

        protected TreeNode LCA(TreeNode root, TreeNode left, TreeNode right)
        {
            if (root == null)
            {
                return null;
            }
            if (root.val < left.val)
            {
                return LCA(root.right, left, right);
            }
            else if (root.val > right.val)
            {
                return LCA(root.left, left, right);
            }

            return root;



        }
    }
}
