using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P560_SubarraySumEqualsK
{
    public class Solution
    {
        public int SubarraySum(int[] nums, int k)
        {
            var result = 0;
            var sum = 0;
            var dict = new Dictionary<int, int>();
            dict.Add(0, 1);
           
            for (var i=0;i<nums.Length; i++)
            {
                sum += nums[i];
                if (!dict.ContainsKey(sum - k))
                {
                    dict.Add(sum - k, 0);
                }
                result += dict[sum-k];
                if (!dict.ContainsKey(sum ))
                {
                    dict.Add(sum , 0);
                }
                dict[sum]++;

            }
            return result;
        }
    }
}
