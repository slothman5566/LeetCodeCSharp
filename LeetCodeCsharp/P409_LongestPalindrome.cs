using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P409_LongestPalindrome
{
    public class Solution
    {
        public int LongestPalindrome(string s)
        {
            if (s.Length == 1)
            {
                return 1;
            }

            var even = 0;
            var odd = 0;

            foreach (var c in s.GroupBy(x => x))
            {
                if (c.Count() % 2 != 0)
                {
                    odd = 1;

                }
                even += c.Count() / 2;
            }
            return even*2+odd;
        }
    }
}
