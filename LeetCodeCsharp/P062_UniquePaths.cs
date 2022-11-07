using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P062_UniquePaths
{
    public class Solution
    {
        public int UniquePaths(int m, int n)
        {
            var grid = Enumerable.Repeat(1, m * n).ToArray();

            for(var i=1;i<m; i++)
            {
                for(var j=1; j < n; j++)
                {
                    grid[i * n + j] = grid[(i-1) * n + j] + grid[i * n + j-1];
                }
            }
            return grid.Last();

        }
    }
}
