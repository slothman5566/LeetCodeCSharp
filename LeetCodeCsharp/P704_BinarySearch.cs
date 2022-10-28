using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P704_BinarySearch
{
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
     
            var start = 0;
            var end = nums.Length - 1;
            while(start <= end)
            {
                var mid = (start + end) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                if (nums[mid] < target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }

            }

            return -1;
        }
    }
}
