using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P108_ConvertSortedArrayToBinarySearchTree
{
    public class Solution
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length == 0)
            {
                return null;
            }
            var start = 0;
            var end = nums.Length;
            var mid = start+end/2;
            var node = new TreeNode(nums[mid]);
            node.left = SortedArrayToBST(nums.Take(mid).ToArray());
            node.right = SortedArrayToBST(nums.Skip(mid+1).ToArray());

            return node;
        }
    }
}
