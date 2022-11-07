using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P033_SearchInRotatedSortedArray
{
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                    return mid;


                //left is sorted
                if (nums[left] <= nums[mid])
                {
                    if (target > nums[mid] || target < nums[left])
                        left = mid + 1;
                    else
                        right = mid - 1;

                }
                //right is sorted
                else
                {
                    if (target > nums[right] || target < nums[mid])
                        right = mid - 1;
                    else
                        left = mid + 1;
                }

            }

            return -1;
        }

      
    }
}
