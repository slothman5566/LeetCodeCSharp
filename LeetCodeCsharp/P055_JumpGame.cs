using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P055_JumpGame
{
    public class Solution
    {
        public bool CanJump(int[] nums)
        {
            
            var count = nums[0];
            var length = nums.Length;

            for(var i=0;i<= count && i<length; i++)
            {
                if (i + nums[i] >= length-1)
                {
                    return true;
                }
                count = Math.Max(count, i + nums[i]);
            }

            return false;
        }
    }
}
