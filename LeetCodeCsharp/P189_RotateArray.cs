using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P189_RotateArray
{
    public class Solution
    {
        public void Rotate(int[] nums, int k)
        {
            int[] numRotated = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                int indexToChange = (i + k) % nums.Length;
                numRotated[indexToChange] = nums[i];
            }
            for (int i = 0; i < numRotated.Length; i++)
            {
                nums[i] = numRotated[i];
            }
            if (k >= nums.Length)
            {
                k %= nums.Length;
            }
            Rerverse(nums, 0, nums.Length - k - 1);
            Rerverse(nums, nums.Length - k , nums.Length - 1);
            Rerverse(nums, 0, nums.Length- 1);

        }

        protected void Rerverse(int[] nums,int start ,int end)
        {

            while (start < end)
            {
                var t = nums[end];
                nums[end] = nums[start];
                nums[start] = t;
                start++;
                end--;
            }
        }
    }
}
