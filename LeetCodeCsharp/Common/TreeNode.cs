using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
        public TreeNode(int x,TreeNode left,TreeNode right) { val = x; this.left = left;this.right = right; }

        public static TreeNode BuildTreeNode(List<int?> list)
        {
            var node = list.Select(x =>
            {
                if (x == null)
                {
                    return null;
                }
                return new TreeNode(x.Value);
            }).ToList();

            var depth = 0;
            var count = 0;
            for (var i = 0; i < node.Count; i++)
            {
                if (i > count)
                {
                    depth++;
                    count += (int)Math.Pow(2, depth);
                    if (count == node.Count - 1)
                    {
                        break;
                    }

                }

                if (node[i] != null && (i * 2 + 1) < node.Count - 1)
                {
                    var temp = (int)Math.Pow(2, depth);
                    node[i].left = node[i * 2 + 1];
                    node[i].right = node[i * 2 + 2];
                }



            }
            return node.First();
        }
    }
}
