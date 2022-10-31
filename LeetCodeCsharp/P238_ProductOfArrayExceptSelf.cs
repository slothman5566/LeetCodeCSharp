using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P238_ProductOfArrayExceptSelf
{
    public class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
			int length = nums.Length;
			var ans =Enumerable.Repeat(1, length).ToArray();

		
			for (int i = 1; i < length; ++i)
			{
				ans[i] = nums[i - 1] * ans[i - 1];
			}

			int result = 1;
			for (int i = length - 1; i >= 0; --i)
			{
				ans[i] = ans[i] * result;
				result *= nums[i];
			}

			return ans;
		}
    }
}
