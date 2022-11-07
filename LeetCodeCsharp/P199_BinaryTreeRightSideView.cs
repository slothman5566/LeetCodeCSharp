using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P199_BinaryTreeRightSideView
{
    public class Solution
    {
      
        public IList<int> RightSideView(TreeNode root)
        {
            List<int> result = new List<int>();
            if (root == null)
            {
                return result;
            }

          

            var quque = new Queue<TreeNode>();
            quque.Enqueue(root);
            while (quque.Count > 0)
            {
                result.Add(quque.Last().val);
                var size = quque.Count;
                for(var i = 0; i < size; i++)
                {
                    var node = quque.Dequeue();
                    if (node.left != null)
                    {
                        quque.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        quque.Enqueue(node.right);
                    }
                }

            }
            return result;
    }
    }
}
