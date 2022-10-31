using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P973_KClosestPointsToOrigin
{
    public class Solution
    {
        Func<int[], int> _CalcuteFunc = (int[] point) => point[0] * point[0] + point[1] * point[1];

        public int[][] KClosest(int[][] points, int k)
        {
          
            Array.Sort(points, (x, y) => {
                return (x[0] * x[0] + x[1] * x[1]) -
                   (y[0] * y[0] + y[1] * y[1]);
            });

            return points.Take(k).ToArray();
        }

    
    }

  
}
