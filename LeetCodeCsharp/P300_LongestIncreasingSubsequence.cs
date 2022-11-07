using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P300_LongestIncreasingSubsequence
{
    public class Solution
    {
        protected int[] _DP;
        public int LengthOfLIS(int[] nums)
        {
            if (nums.Length == 0) return 0;

            _DP = Enumerable.Repeat(1,nums.Length).ToArray();
            int length = 0;
            for (var i = 1; i < nums.Length; i++)
            {
                for(var j=0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        _DP[i] = Math.Max(_DP[i], _DP[j] + 1);
                    }
                }
                //length = Math.Max(length, LIS(nums, i));
            }
            return _DP.Max();
        }

        private int LIS(int[] nums,int r)
        {
            if (r == 0)
            {
                return 1;
            }
            if (_DP[r] > 0) return _DP[r];
            var ans = 1;
            for(var i=0; i < r; i++)
            {
                if (nums[r] > nums[i])
                    ans = Math.Max(ans, LIS(nums, i) + 1);
            }
            _DP[r] = ans;
            return _DP[r];



        }
    }
}
