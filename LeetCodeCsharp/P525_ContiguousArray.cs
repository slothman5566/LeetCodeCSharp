using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P525_ContiguousArray
{
    public class Solution
    {
        public int FindMaxLength(int[] nums)
        {
            var map = new Dictionary<int, int>();
            map.Add(0, -1);

            var maxlen = 0;
            var count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                count += nums[i] == 1 ? 1 : -1;
                if (map.ContainsKey(count))
                    maxlen = Math.Max(maxlen, i - map[count]);
                else
                    map.Add(count, i);

            }

            return maxlen;
        }
    }
}
