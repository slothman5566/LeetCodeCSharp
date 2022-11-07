using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P739_DailyTemperatures
{
    public class Solution
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
           
            var result = new int[temperatures.Length];
            if (temperatures.Length == 1)
            {
                return result;
            }

            var stack = new Stack<int>();
            for(var i = temperatures.Length - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && temperatures[i] >= temperatures[stack.Peek()])
                    stack.Pop();
                result[i] = stack.Count == 0 ? 0 : (stack.Peek() - i);
                stack.Push(i);

            }

            return result;
        }
    }
}
