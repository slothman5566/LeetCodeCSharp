using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P031_NextPermutation
{
    public class Solution
    {
        public void NextPermutation(int[] nums)
        {
            var j = 0;
            for (var i=nums.Length-2;i>=0; i--)
            {
                if (nums[i +1]>nums[i ]){
                    for(j=nums.Length-1;j>i; j--)
                    {
                        if (nums[j] > nums[i])
                        {
                            break;
                        }
                    }
                    var temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    Array.Reverse(nums,i+1, nums.Length-i-1 );
              
                    return;
                }

            }

            Array.Reverse(nums);
        }
    }
}
