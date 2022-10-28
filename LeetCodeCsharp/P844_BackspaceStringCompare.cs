using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P844_BackspaceStringCompare
{
    public class Solution
    {
        public bool BackspaceCompare(string s, string t)
        {
            int i = (int)s.Length - 1, j = (int)t.Length - 1, cnt1 = 0, cnt2 = 0;
            while (i >= 0 || j >= 0)
            {
                while (i >= 0 && (s[i] == '#' || cnt1 > 0)) {
                    if(s[i--] == '#')
                    {
                        cnt1++;
                    }
                    else
                    {
                        cnt1--;
                    }
                   
                }
                while (j >= 0 && (t[j] == '#' || cnt2 > 0))
                {
                    if (t[j--] == '#')
                    {
                        cnt2++;
                    }
                    else
                    {
                        cnt2--;
                    }
                }
                if (i < 0 || j < 0) return i == j;
                if (s[i--] != t[j--]) return false;
            }
            return i == j;
            //return BackspaceString(s).SequenceEqual(BackspaceString(t));
        }

        protected Stack<char> BackspaceString(string s)
        {
            var stack = new Stack<char>();
            foreach(var c in s)
            {
                
                if ( c == '#')
                {
                    if(stack.Count > 0)
                    {
                        stack.Pop();
                    }
                    
                }
                else
                {
                    stack.Push(c);
                }
            }
            return stack;
        }
    }
}
