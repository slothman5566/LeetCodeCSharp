using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P424_LongestRepeatingCharacterReplacement
{
    public class Solution
    {
        public int CharacterReplacement(string s, int k)
        {
            int res = 0, maxCnt = 0, start = 0;
            var counts=new int[26];
            for (int i = 0; i < s.Length; ++i)
            {
                maxCnt = Math.Max(maxCnt, ++counts[s[i] - 'A']);
                while (i - start + 1 - maxCnt > k)
                {
                    --counts[s[start] - 'A'];
                    ++start;
                }
                res = Math.Max(res, i - start + 1);
            }
            return res;
        }
    }
}
