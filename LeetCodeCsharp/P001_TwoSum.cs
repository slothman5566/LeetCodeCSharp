using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P001_TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {

                    return new int[] { dict[nums[i]], i };


                }
                else
                {
                    dict[target - nums[i]] = i;
                   

                }
            }
            throw new ArgumentException();
        }
    }
}
