using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P020_ValidParentheses
{
    public class Solution
    {
        protected Dictionary<char, char> _ValidDict = new Dictionary<char, char>() {
           { ')','(' },{ ']','[' },{ '}','{' },

        };
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();

            foreach (var c in s)
            {
                if (stack.Count()>0 && _ValidDict.ContainsKey(c) && _ValidDict[c] == stack.Peek())
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }
 
            return stack.Count==0;
        }


    }
}
