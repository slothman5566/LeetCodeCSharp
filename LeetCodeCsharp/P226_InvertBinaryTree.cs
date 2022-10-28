using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P226_InvertBinaryTree
{



    public class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {

            if (root == null)
            {
                return root;
            }

         
            
            InvertTree(root.left);
            InvertTree(root.right);

            var temp = root.left;
            root.left = root.right;
            root.right = temp;

            return root;
        }
    }
}
