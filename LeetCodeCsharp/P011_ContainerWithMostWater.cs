using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P011_ContainerWithMostWater
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
          
            var max = 0;

            int left = 0, right = height.Length-1;

            while (left < right)
            {
                max = Math.Max(max, (right - left) * Math.Min(height[right], height[left]));
                if (height[right] < height[left])
                {
                    right--;
                }
                else { left++; }

            }
            return max;

        }
    }
}
