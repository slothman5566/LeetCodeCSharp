using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P169_MajorityElement
{
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            var dict = new Dictionary<int, int>();

            for(var i=0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]] = 0;
                }
                dict[nums[i]]+=1;
                if(dict[nums[i]]> nums.Length / 2)
                {
                    return nums[i];
                }
            }
            throw new ArgumentException();
        }
    }
}
