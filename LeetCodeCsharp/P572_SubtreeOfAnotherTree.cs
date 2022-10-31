using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P572_SubtreeOfAnotherTree
{
    public class Solution
    {
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            if (root == null )
            {
                return false;
            }
            return IsSameTree(root, subRoot) || IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
        }
        protected bool IsSameTree(TreeNode p, TreeNode q)
        {
          
            if (p == null || q == null)
            {
                return p==q;
            }
            return p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right)  ; 
        }

     
    }
}
