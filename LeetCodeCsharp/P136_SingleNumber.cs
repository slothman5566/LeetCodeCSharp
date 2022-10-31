using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P136_SingleNumber
{
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            var result = 0;
            foreach(var n in nums)
            {
                result ^= n;
            }
            return result;
        }
    }
}
