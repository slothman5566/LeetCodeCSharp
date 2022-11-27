using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P227_BasicCalculatorII
{
    public class Solution
    {
        public int Calculate(string s)
        {
            char sign = '+';
            var stack = new Stack<int>();
            int current = 0;

            for (int i = 0; i <= s.Length; i++)
            {
                if (i < s.Length && s[i] >= '0' && s[i] <= '9')
                    current = current * 10 + s[i] - '0';
                else if (i == s.Length || s[i] != ' ')
                {
                    if (sign == '+') stack.Push(current);
                    else if (sign == '-') stack.Push(-current);
                    else if (sign == '*')
                    {
                        var pre = stack.Pop();
                        stack.Push(pre * current);
                    }
                    else if (sign == '/')
                    {
                        var pre = stack.Pop();
                        stack.Push(pre / current);
                    }

                    if (i < s.Length)
                    {
                        current = 0;
                        sign = s[i];
                    }
                }
            }

            var res = 0;
            while (stack.Count > 0)
                res += stack.Pop();
            return res;
        }
    }
}
