using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P003_LongestSubstringWithoutRepeatingCharacters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var max = 0;
            var left = 0;
         
            var dict = new Dictionary<char, int>();
            for ( var right = 0; right < s.Length; right++)
            {
                if (dict.ContainsKey(s[right]))
                {
                    left = Math.Max(left,  dict[s[right]]);
                }

                max = Math.Max(max, right - left + 1);
                dict[s[right]] = right + 1;
            }
            return max;
        }
    }

}
