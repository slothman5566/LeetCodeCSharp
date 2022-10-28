using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P242_ValidAnagram
{
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            var charArray = new int[26];
            for(var i=0;i<s.Length; i++)
            {
                charArray[s[i] - 'a']++;
                charArray[t[i] - 'a']--;
            }

            return !charArray.Any(x=>x!=0);
        }
    }
}
