using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P098_ValidateBinarySearchTree
{
    public class Solution
    {
        protected TreeNode _PreNode = null;
        public bool IsValidBST(TreeNode root)
        {
            _PreNode = null;
            return InOder(root);
           
        }

        public bool InOder(TreeNode node)
        {
            if (node == null)
            {
                return true;
            }

        
            if (!InOder(node.left))
            {
                return false;
            }
            if (_PreNode != null && node.val <= _PreNode.val)
            {
                return false;
               
            }
            _PreNode = node;
            return InOder(node.right);
          
           

        }

    }
}
