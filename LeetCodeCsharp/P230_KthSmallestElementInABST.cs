using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P230_KthSmallestElementInABST
{
    public class Solution
    {
        public int KthSmallest(TreeNode root, int k)
        {
            var stack =new Stack<TreeNode>();
            var count = 0;
            while(root!=null || stack.Count > 0)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                root = stack.Pop();
                count++;
                if (count == k)
                {
                    return root.val;
                }
                root = root.right;
            }
            return 0;
        }
    }
}
