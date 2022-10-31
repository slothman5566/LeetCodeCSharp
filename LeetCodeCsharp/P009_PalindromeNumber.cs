using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P009_PalindromeNumber
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
                
            var temp = x;
            var reuslt = 0;
            while (temp > 0)
            {
                reuslt = reuslt * 10 + temp % 10;
                temp = temp / 10;
            }
            return x == reuslt;
        }
    }
}
