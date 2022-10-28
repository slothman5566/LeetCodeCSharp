using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P100_SameTree
{
    public class Solution
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if(p==null && q == null)
            {
                return true;
            }
            if(p==null || q == null)
            {
                return false;
            }
            return p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}
