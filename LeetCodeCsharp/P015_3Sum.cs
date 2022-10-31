using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P015_3Sum
{
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {

            var result = new List<IList<int>>();

            Array.Sort(nums);
            for (int first = 0; first < nums.Length - 2; first++)
            {
               
                if (first > 0 && nums[first] == nums[first - 1])
                {
                    continue;
                }
                int second = first + 1;
                int third = nums.Length - 1;
                while (second < third)
                {
                    if (nums[second] == nums[second - 1] && second > first + 1)
                    {
                        second++;
                        continue;
                    }
                    int sum = nums[first] + nums[second] + nums[third];
                    if (sum == 0)
                    {

                        result.Add(new List<int>
                    {
                        nums[first],
                        nums[second],
                        nums[third]
                    });
                        second++;
                        third--;
                    }
                    else if (sum < 0)
                    {
                        second++;
                    }
                    else
                    {
                        third--;
                    }
                }
            }
            return result;
       
        }
    }
}
