using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P102_BinaryTreeLevelOrderTraversal
{
    public class Solution
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var result =new  List<IList<int>>();
            LevelOrder(root, result, 0);
            return result;
        }

        public void LevelOrder(TreeNode root, List<IList<int>> list,int level)
        {
            if (root == null)
            {
                return;
            }
            if (list.Count == level)
            {
                list.Add(new List<int>());
            }
            list[level].Add(root.val);
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
