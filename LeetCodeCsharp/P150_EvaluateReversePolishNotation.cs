using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P150_EvaluateReversePolishNotation
{
    public class Solution
    {
        public int EvalRPN(string[] tokens)
        {
            var stack = new Stack<int>();
            var first = 0;
            var second = 0;
            foreach (var token in tokens)
            {
                switch (token)
                {
                    case "+":
                       
                        stack.Push(stack.Pop() + stack.Pop());
                        break;
                    case "-":
                        first = stack.Pop();
                        second = stack.Pop();
                        stack.Push(second - first);
                        break;
                    case "*":
                        stack.Push(stack.Pop() * stack.Pop());
                        break;
                    case "/":
                        
                        first = stack.Pop();
                        second = stack.Pop();
                        stack.Push( second/ first );
                        break;
                    default:
                        stack.Push(Convert.ToInt32(token));
                        break;
                }
            }
            return stack.Pop();
        }
    }
}
