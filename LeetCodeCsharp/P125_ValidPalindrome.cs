using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P125_ValidPalindrome
{
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            var list = s.Where(x => Char.IsLetterOrDigit(x)).Select(x => Char.ToUpper(x));

            return list.SequenceEqual(list.Reverse());
        }
    }
}
