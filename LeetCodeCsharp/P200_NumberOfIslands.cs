using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P200_NumberOfIslands
{
    public class Solution
    {
        public int NumIslands(char[][] grid)
        {
            var m = grid.Length;
            var n = grid[0].Length;
            var result = 0;
            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {

                    if (grid[i][j] == '1')
                    {
                        result++;
                        DFS(grid,i,j,m,n);
                    }
                }
            }
            return result;
        }

        protected void DFS(char[][] grid, int x, int y, int m, int n)
        {
            if (x >= m || y >= n || x < 0 || y < 0 || grid[x][y] == '0')
            {
                return;
            }
            grid[x][y] = '0';
            DFS(grid, x + 1, y, m, n);
            DFS(grid, x, y + 1, m, n);
            DFS(grid, x - 1, y, m, n);
            DFS(grid, x, y - 1, m, n);
        }
    }
}
