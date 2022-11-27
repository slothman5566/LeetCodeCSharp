using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P662_MaximumWidthOfBinaryTree
{
    public class Solution
    {
        public int WidthOfBinaryTree(TreeNode root)
        {
            if (root == null)
            {
                return 0;

            }

            var result = 0;

            var quque = new Queue<(TreeNode, int)>();
            quque.Enqueue((root,1));

            while (quque.Count > 0)
            {
                var left = quque.Peek().Item2;
                var count = quque.Count;
                var right = 0;
                for(var i=0;i<count; i++)
                {
                    var temp = quque.Dequeue();
                    right = temp.Item2;
                    if (temp.Item1.left != null)
                    {
                        quque.Enqueue((temp.Item1.left, right * 2));
                    }
                    if (temp.Item1.right != null)
                    {
                        quque.Enqueue((temp.Item1.right, right * 2+1));
                    }

                }
                result = Math.Max(result, right - left + 1);

            }


            return result;
        }

       
    }
}
