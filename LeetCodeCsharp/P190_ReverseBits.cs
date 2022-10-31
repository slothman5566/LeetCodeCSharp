using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P190_ReverseBits
{
    public class Solution
    {
        public uint reverseBits(uint n)
        {
            uint count = 0;
            for(var i=0; i < 32; i++)
            {
                count = count << 1;
                if ((n & 1) == 1)
                {
                    count++;

                }
                

                n = n >> 1;
            }
           
            return count;
        }
    }
}
