using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P101_SymmetricTree
{ 
   public class Solution
    {
        // P100_SameTree
        public bool IsSymmetric(TreeNode root)
        {
            if (root== null){
                return false;
            }
            return IsMirrorTree(root.left,root.right);
        }
        protected bool IsMirrorTree(TreeNode p, TreeNode q)
        {
       
            if (p == null || q == null)
            {
                return p==q;
            }
            return p.val == q.val && IsMirrorTree(p.left, q.right) && IsMirrorTree(p.right, q.left);
        }
    }
}
