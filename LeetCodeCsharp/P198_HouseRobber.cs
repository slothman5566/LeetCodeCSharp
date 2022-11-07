using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P198_HouseRobber
{
    public class Solution
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            if (nums.Length == 1)
            {
                return nums.First();
            }
            var rob = new int[nums.Length];
            rob[0] = nums[0];
            rob[1] = Math.Max(nums[0],nums[1]);
            for (var i=2; i < nums.Length; i++)
            {
                rob[i] = Math.Max(rob[i - 1], rob[i - 2] + nums[i]);
            }
            return rob.Last();

        }
    }
}
