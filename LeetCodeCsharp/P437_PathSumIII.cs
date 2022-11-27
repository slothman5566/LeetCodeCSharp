using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P437_PathSumIII
{
    public class Solution
    {


        public int PathSum(TreeNode root, int targetSum)
        {
            if (root == null) return 0;

            Dictionary<int, int> cache = new Dictionary<int, int>() { { 0, 1 } };


            return DFS(root, targetSum, 0, cache);
        }
        public int DFS(TreeNode root, int target, int currPathSum, Dictionary<int, int> cache)
        {
            if (root == null) return 0;

            currPathSum += root.val;

            int oldPathSum = currPathSum - target;
            if (!cache.ContainsKey(oldPathSum))
            {
                cache.Add(oldPathSum, 0);
            }

            var result = cache[oldPathSum];

            if (!cache.ContainsKey(currPathSum))
                cache.Add(currPathSum, 0);
            cache[currPathSum]++;

            result += DFS(root.left, target, currPathSum, cache);
            result += DFS(root.right, target, currPathSum, cache);
            cache[currPathSum] -= 1;

            return result;
        }
    }
}
