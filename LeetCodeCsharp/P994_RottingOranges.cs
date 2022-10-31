using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P994_RottingOranges
{
    public class Solution
    {
        public int OrangesRotting(int[][] grid)
        {
            var m = grid.Length;
            var n = grid[0].Length;
            var queue = new Queue<(int,int)>();
            var count = 0;
            var time = 0;
            var dir = new int[] { 0, 1, 0, -1, 0 };
            for(var i=0;i<m; i++)
            {
                for(var j=0;j<n; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        count++;
                    }else if(grid[i][j] == 2)
                    {

                        queue.Enqueue((i, j));
                    }
                }
            }
    
            
            while(queue.Count>0 && count>0)
            {
                var size = queue.Count;
                for(var _=0; _ < size; _++)
                {
                    var front = queue.Dequeue();
                  
                    for (var i=0; i < 4; i++)
                    {
                        var x = front.Item1+ dir[i];
                        var y = front.Item2+ dir[i + 1];
                        if(x<0 || y<0 ||x>=m || y>=n || grid[x][y] == 0)
                        {
                            continue;
                        }
                        if (grid[ x][y] == 1)
                        {
                            grid[x][y] = 2;
                            count--;
                            queue.Enqueue((x,y));
                        }
                    }
                }
                time++;
            }
            return count > 0 ? -1 : time;
        }
    }
}
