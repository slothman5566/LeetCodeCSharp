using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P007_ReverseInteger
{
    public class Solution
    {
        public int Reverse(int x)
        {
            var result = 0;

            for (; x != 0; x /= 10)
            {
                if (result > int.MaxValue / 10 || result < int.MinValue / 10)
                {
                    return 0;
                }
                result = result * 10 + x % 10;
               
            }


       
            return result;
        }
    }
}
