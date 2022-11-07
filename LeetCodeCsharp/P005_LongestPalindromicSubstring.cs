using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P005_LongestPalindromicSubstring
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            var len = 0;
            var start = 0;
            for(var i = 0; i < s.Length; i++)
            {
                var current = Math.Max(GetLen(s, i, i), GetLen(s,i,i+1));
                if (current > len)
                {
                    len = current;
                    start = i - (current - 1) / 2;
                }
            }
            return s.Substring(start,  len);
        }

        private int  GetLen(string s,int left,int right)
        {
            while(left>=0 && right<s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            return right - left - 1;
        }
    }
}
