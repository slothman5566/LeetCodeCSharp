using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P621_TaskScheduler
{
    public class Solution
    {
        public int LeastInterval(char[] tasks, int n)
        {
            var c = new int[26];
            foreach(var t in tasks)
            {
                c[t - 'A']++;
            }
            Array.Sort(c);
            int i = 25;
            while (i >= 0 && c[i] == c[25]) i--;

            return Math.Max(tasks.Length, (c[25] - 1) * (n + 1) + 25 - i);
        }
    }
}
