using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P215_KthLargestElementInAnArray
{
    public class Solution
    {
        public int FindKthLargest(int[] nums, int k)
        {
            int n = nums.Length;
            // k largest is the same as (N - k) smallest
            return Helper(nums, 0, n - 1, n - k);
        }
        public int Helper(int[] nums, int left, int right, int k)
        {
            if (left == right)
                return nums[left];

            int p = Partition(nums, left, right);

            if (k == p)
            {
                return nums[k];
            }
            else if (k < p) // left side partition 
            {
                return Helper(nums, left, p - 1, k);
            }
            else // right side partition
            {
                return Helper(nums, p + 1, right, k);
            }
        }
        public int Partition(int[] nums ,int left, int right)
        {
            int pivot_index = right;
            int store_index = left;  // store is the pointer of the last swap element, initially is the same as left
            for (int i = left; i <= right; i++)
            {
                if (nums[i] < nums[pivot_index])  // all the values less than pivot
                {
                    Swap(nums, store_index, i);
                    store_index++;
                }
            }
            // move the pivot to the sorted position
            Swap(nums, store_index, right);
            return store_index;
        }
        private void Swap(int[] nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
