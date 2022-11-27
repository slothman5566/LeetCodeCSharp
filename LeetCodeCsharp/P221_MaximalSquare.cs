using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P221_MaximalSquare
{
    public class Solution
    {
        public int MaximalSquare(char[][] matrix)
        {
            var m = matrix.Length;
            var n = matrix[0].Length;
            var dp = new int[m][];
            var result = 0;
            for (var i = 0; i < m; i++)
            {
                dp[i] = new int[n];
            }
            for (var x = 0; x < m; x++)
            {
                for (var y = 0; y < n; y++)
                {
                    if (x == 0 || y == 0)
                    {
                        dp[x][y] = matrix[x][y] - '0';
                    }else if (matrix[x][y] == '1')
                    {
                        dp[x][y] = Math.Min(dp[x-1][y-1],Math.Min(dp[x-1][y],dp[x][y-1]))+1;

                    }
                    result = Math.Max(result, dp[x][y]);
                }
            }
            return result;
        }
    }
}
