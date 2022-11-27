using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P435_NonOverlappingIntervals
{
    public class Solution
    {
        public int EraseOverlapIntervals(int[][] intervals)
        {
            var result = 0;
            var last = 0;
            Array.Sort(intervals,(x,y)=>x[0].CompareTo(y[0]));
            for(var i=1;i<intervals.Length; i++)
            {
                if (intervals[i][0] < intervals[last][1])
                {
                    result++;
                    if (intervals[i][1] < intervals[last][1]) last = i;
                }
                else
                {
                    last = i;
                }
            }

            return result;

        }
    }
}
