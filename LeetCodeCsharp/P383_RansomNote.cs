using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P383_RansomNote
{
    public class Solution
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            if (magazine.Length < ransomNote.Length)
            {
                return false;
            }
            var charArray = new int[26];
            for (var i = 0; i < magazine.Length; i++)
            {
                if (i < ransomNote.Length)
                {
                    charArray[ransomNote[i] - 'a']--;
                }
               
                charArray[magazine[i] - 'a']++;
            }
          
            return !charArray.Any(x => x < 0);
        }
    }
}
