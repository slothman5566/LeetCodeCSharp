using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P283_MoveZeroes
{
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int pointer = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    if (pointer != i)
                    {
                        nums[pointer] = nums[i];
                        nums[i] = 0;
                    }
                    pointer++;
                }
            }
        }
    }
}
