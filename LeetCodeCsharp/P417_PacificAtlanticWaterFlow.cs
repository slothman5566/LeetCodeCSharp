using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P417_PacificAtlanticWaterFlow
{
    public class Solution
    {
        public IList<IList<int>> PacificAtlantic(int[][] heights)
        {
            var result = new List<IList<int>>();
            var m = heights.Length;
            var n = heights[0].Length;
            var pacific = new bool[m, n];
            var atlantic = new bool[m, n];

            for (var i = 0; i < m; i++)
            {
                DFS(heights, pacific, int.MinValue, i, 0);
                DFS(heights, atlantic, int.MinValue, i, n - 1);

            }

            for (var i = 0; i < n; i++)
            {
                DFS(heights, pacific, int.MinValue, 0, i);
                DFS(heights, atlantic, int.MinValue, m - 1, i);

            }

            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {

                    if (pacific[i, j] && atlantic[i, j])
                    {
                        result.Add(new List<int>() { i, j });
                    }
                }
            }

            return result;
        }

        protected void DFS(int[][] heights, bool[,] visited, int pre, int x, int y)
        {
            var m = heights.Length;
            var n = heights[0].Length;
            if (x < 0 || x >= m || y < 0 || y >= n || visited[x, y] || heights[x][y] < pre)
            {
                return;
            }

            visited[x, y] = true;
            DFS(heights, visited, heights[x][y], x + 1, y);
            DFS(heights, visited, heights[x][y], x - 1, y);
            DFS(heights, visited, heights[x][y], x, y + 1);
            DFS(heights, visited, heights[x][y], x, y - 1);
        }

    }
}
