using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P056_MergeIntervals
{
    public class Solution
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length == 1)
            {
                return intervals;
            }
            Array.Sort(intervals, (x, y) =>x[0].CompareTo(y[0]) );
            var result = new List<int[]>();

            var newInterval = intervals.First();
            foreach (var i in intervals.Skip(1))
            {
                if (newInterval[0] > i[1])
                {
                    result.Add(i);
                }
                else if (newInterval[1] < i[0])
                {
                    result.Add(newInterval);
                    newInterval = i;
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
