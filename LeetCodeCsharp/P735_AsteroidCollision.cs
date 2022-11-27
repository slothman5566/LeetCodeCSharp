using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P735_AsteroidCollision
{
    public class Solution
    {
        public int[] AsteroidCollision(int[] asteroids)
        {
            var stack = new Stack<int>();
            foreach (var aster in asteroids)
            {
                stack.Push(aster);
                while (stack.Count > 1)
                {
                    var first = stack.Pop();
                    var second = stack.Pop();
                 
                    if ((first > 0 && second > 0) || (second < 0 && first < 0) || (first>0 && second<0))
                    {
                        stack.Push(second);
                        stack.Push(first);
                        break;
                    }
                    if (first + second == 0)
                    {
                        continue;
                    }
                    if (first < 0)
                    {
                        if (first + second < 0)
                        {
                            stack.Push(first);
                        }
                        else
                        {
                            stack.Push(second);
                        }

                    }
                }

            }
           
            return stack.Reverse().ToArray();
        }
    }
}
