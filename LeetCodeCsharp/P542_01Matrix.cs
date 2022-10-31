using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P542_01Matrix
{
    public class Solution
    {
        public int[][] UpdateMatrix(int[][] mat)
        {
            var m = mat.Length;
            var n = mat[0].Length;
            var result = new int[m][];

            for (var i = 0; i < m; i++)
            {
                result[i] = Enumerable.Repeat<int>(int.MaxValue-1, n).ToArray();

            }

            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (mat[i][j] == 1)
                    {
                       
                        if (i - 1 >= 0)
                        {
                            result[i][j] = Math.Min(result[i][j], result[i - 1][j] + 1);
                        }
                        if (j - 1 >= 0)
                        {
                            result[i][j] = Math.Min(result[i][j], result[i][j - 1] + 1);
                        }
                    }
                    else
                    {
                        result[i][j] = 0;


                    }
                }
            }

            for (var i = m-1; i >=0; i--)
            {
                for (var j = n-1; j >=0; j--)
                {
                    if (result[i][j] >1)
                    {
                        if (i + 1 < m)
                        {
                            result[i][j] = Math.Min(result[i][j], result[i + 1][j] + 1);
                        }
                        if (j + 1 < n)
                        {
                            result[i][j] = Math.Min(result[i][j], result[i][j + 1] + 1);
                        }
                       
                    }
                }
            }
            return result;
        }
    }
}
