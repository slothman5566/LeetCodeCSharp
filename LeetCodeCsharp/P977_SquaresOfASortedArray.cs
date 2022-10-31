using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P977_SquaresOfASortedArray
{
    public class Solution
    {
        public int[] SortedSquares(int[] nums)
        {
            int length = nums.Length;
            int[] result = new int[length];
            int index = length - 1;
            int left = 0, right = length - 1;
            while (left <= right)
            {
                if (Math.Abs(nums[left]) < Math.Abs(nums[right]))
                {
                    result[index--] = nums[right] * nums[right];
                    right--;
                }
                else
                {
                    result[index--] = nums[left] * nums[left];
                    left++;
                }
            }
            return result;
        }
    }
}
