using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P128_LongestConsecutiveSequence
{
    public class Solution
    {
        public int LongestConsecutive(int[] nums)
        {
            var result = 0;
            var set = new HashSet<int>();
            foreach(var n in nums)
            {
                set.Add(n);
            }

            foreach (var n in nums)
            {
                if (set.Remove(n))
                {
                    var pre = n - 1;
                    var next = n + 1;
                    while (set.Remove(pre)) pre--;
                    while (set.Remove(next)) next++;
                    result = Math.Max(result, next - pre - 1);
                }
               
            }
            return result;
        }
    }
}
