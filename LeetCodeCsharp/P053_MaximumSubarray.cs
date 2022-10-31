using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P053_MaximumSubarray
{
    // o(n^2)
    public class Solution1
    {
        public int MaxSubArray(int[] nums)
        {
            int length = nums.Length;

            int globalMax = int.MinValue;
            
            for(var i=0;i<length; i++)
            {
                var sum = 0;
                for(var j = i; j < length; j++)
                {
                    sum += nums[j];
                    globalMax=Math.Max(globalMax, sum);
                }
            }
           

            return globalMax;
        }
    }
    // o(n)
    public class Solution2
    {
        public int MaxSubArray(int[] nums)
        {
            int length = nums.Length;

            int globalMax = nums[0];
            int localMax = nums[0];

            for (int i = 1; i < length; ++i)
            {
                localMax = Math.Max(nums[i], localMax + nums[i]);
                globalMax = Math.Max(localMax, globalMax);
            }

            return globalMax;
        }
    }
}
