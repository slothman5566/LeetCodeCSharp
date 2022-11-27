using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P394_DecodeString
{
    public class Solution
    {
        public string DecodeString(string s)
        {
          
            var strStack = new Stack<string>();
            var numStack = new Stack<int>();
            var temp = string.Empty;
            var count = 0;
            foreach (var c in s)
            {
                if (char.IsDigit(c))
                {
                    count = 10 * count + c-'0';
                   
                }
                else if (c == '[')
                {
                    numStack.Push(count);
                    strStack.Push(temp);
                    temp = string.Empty;
                    count = 0;

                }
                else if (c == ']')
                {
                    var tempCount = numStack.Pop();
                    temp = strStack.Pop()+ string.Concat(Enumerable.Repeat(temp, tempCount));
                }
                else 
                {
                    temp +=  c;
                   
                }

            }
       
          

            return strStack.Count==0? temp:strStack.Peek();
        }

   
    }
}
