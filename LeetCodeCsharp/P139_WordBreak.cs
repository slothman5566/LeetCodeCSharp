using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P139_WordBreak
{
    public class Solution
    {
        protected Dictionary<string, bool> _Dict = new Dictionary<string, bool>();
        public bool WordBreak(string s, IList<string> wordDict)
        {
            if (_Dict.ContainsKey(s))
                return _Dict[s];
            if (s == "")
                return true;

            foreach (string word in wordDict)
            {
                if (s.IndexOf(word) == 0)
                {
                    _Dict[s] = WordBreak(s.Substring(word.Length, s.Length - word.Length), wordDict);
                    if (_Dict[s])
                        return true;
                }
            }
            _Dict[s] = false;
            return false;
        }
    }
}
