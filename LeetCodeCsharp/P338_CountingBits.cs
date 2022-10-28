using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P338_CountingBits
{
    public class Solution
    {
        public int[] CountBits(int n)
        {
            if (n == 0)
            {
                return new int[] { 0};
            }
            var array = new int[n+1];
            array[1] = 1;

            for (var i= 2; i < n+1; i++)
            {
                array[i] = array[i / 2] + array[i % 2];
            }
            return array;
        }
    }

}
