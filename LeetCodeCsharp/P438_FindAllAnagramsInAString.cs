using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P438_FindAllAnagramsInAString
{
    public class Solution
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            var sLength = s.Length;
            var pLength = p.Length;

            var pCount = new int[26];
            foreach (var ch in p)
                pCount[ch - 'a']++;

            var sCount = new int[26];
            var result = new List<int>();
            for (int i = 0; i < sLength; i++)
            {
                sCount[s[i] - 'a']++;
                if (i >= pLength)
                    sCount[s[i - pLength] - 'a']--;

                if (Enumerable.SequenceEqual(sCount, pCount))
                    result.Add(i - pLength + 1);
            }

            return result;
        }
    }
}
