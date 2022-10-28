using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P013_RomanToInteger
{
    public class Solution
    {
        protected Dictionary<char, int> _RomanDict = new Dictionary<char, int>()
        {
            { 'I',1 },
            { 'V',5 },
            { 'X',10 },
            { 'L',50 },
            { 'C',100 },
            { 'D',500 },
            { 'M',1000 }
        };
        public int RomanToInt(string s)
        {
            var result = 0;
            
            for(var i=0; i < s.Length; i++)
            {
                if(i+1!=s.Length &&  _RomanDict[s[i]]< _RomanDict[s[i + 1]])
                {
                    result -= _RomanDict[s[i]];
                }
                else
                {
                    result += _RomanDict[s[i]];
                }

            }

            return result;
        }
    }
}
