using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P191_NumberOf1Bits
{
    public class Solution
    {
        uint _Flag = 1;
        public int HammingWeight(uint n)
        {

            var count = 0;
            while (n > 0)
            {
                if ((n & 1) == 1) count++;
                n = n >> 1;
            }
            return count;

        }
    }
}
