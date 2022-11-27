using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P103_BinaryTreeZigzagLevelOrderTraversal
{
    public class Solution
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();
            LevelOrder(root, result, 0);
            return result;
        }

        public void LevelOrder(TreeNode root, List<IList<int>> list, int level)
        {
            if (root == null)
            {
                return;
            }
            if (list.Count == level)
            {
                list.Add(new List<int>());
            }
            if (level % 2 == 0)
            {
                list[level].Add(root.val);
            }
            else
            {
              
                list[level].Insert(0,root.val);
            }
          
            if (root.left != null)
            {
                LevelOrder(root.left, list, level + 1);
            }
            if (root.right != null)
            {
                LevelOrder(root.right, list, level + 1);
            }
        }
    }
}
