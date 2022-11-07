using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P152_MaximumProductSubarray
{
    public class Solution
    {
        public int MaxProduct(int[] nums)
        {
            var length = nums.Length;

            var globalMax = nums[0];
            var localMax = nums[0];
            var localMin=nums[0];
            for (int i = 1; i < length; ++i)
            {
                if (nums[i] < 0)
                {
                    localMax ^= localMin;
                    localMin ^= localMax;
                    localMax ^= localMin;
                }
                localMax = Math.Max(nums[i], localMax * nums[i]);
                localMin = Math.Min(nums[i], localMin * nums[i]);
                globalMax = Math.Max(localMax, globalMax);
            }

            return globalMax;
        }
    }
}
