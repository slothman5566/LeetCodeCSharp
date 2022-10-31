using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P057_InsertInterval
{
    public class Solution
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            if (intervals.Length == 0)
            {
                return new int[][] { newInterval };
            }
            var result = new List<int[]>();
           
          
            foreach (var i in intervals)
            {
                if (newInterval[0] > i[1])
                {
                    result.Add(i);
                }else if (newInterval[1] < i[0])
                {
                    result.Add(newInterval);
                    result.AddRange(intervals.Skip(Array.IndexOf(intervals, i)));
                    return result.ToArray();
                }
                else
                {
                    newInterval[0] = Math.Min(newInterval[0], i[0]);
                    newInterval[1] = Math.Max(newInterval[1], i[1]);
                }

              

            }

            result.Add(newInterval);


            return result.ToArray();
        }
    }
}
