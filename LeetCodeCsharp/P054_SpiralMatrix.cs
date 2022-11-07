using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P054_SpiralMatrix
{
    public class Solution
    {


        public IList<int> SpiralOrder(int[][] matrix)
        {
            var m = matrix.Length;
            var n = matrix[0].Length;
            var _Result = new List<int>();
            int startX = 0, startY = 0;
            var dirs = new int[] { 0, 1, 0, -1, 0 };

            while (_Result.Count < m * n)
            {
                _Result.Add(matrix[startX][startY]);
                matrix[startX][startY] = int.MinValue;
                for (var i = 0; i < 4; i++)
                {
                    var x = startX;
                    var y = startY;
                    while (true)
                    {
                        x = x + dirs[i];
                        y = y + dirs[i + 1];

                        if (x >= m || y >= n || x < 0 || y < 0 || matrix[x][y] == int.MinValue)
                        {
                            break;
                        }
                        _Result.Add(matrix[x][y]);
                        matrix[x][y] = int.MinValue;
                        startX = x;
                        startY = y;
                    }
                }

                startY++;
            }
            return _Result;
        }
    }
}
