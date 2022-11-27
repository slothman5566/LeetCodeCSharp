using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P210_CourseScheduleII
{
    public class Solution
    {
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
           
            var map = new Dictionary<int, HashSet<int>>();
            foreach (var prerequisite in prerequisites)
            {
               
                if (!map.ContainsKey(prerequisite[1]))
                {
                    map[prerequisite[1]] = new HashSet<int>();
                }

                map[prerequisite[1]].Add(prerequisite[0]);

            }
                

            var visited = new int[numCourses];
            var result = new List<int>();
            for (int i = 0; i < numCourses; i++)
                if (visited[i] == 0 && !DFS(map, visited, i, numCourses, result)) return new int[] { };

            result.Reverse();
            return result.ToArray();
        }

        private bool DFS(Dictionary<int, HashSet<int>> map, int[] visited, int i, int numCourses, IList<int> result)
        {
            visited[i] = 1;
            for (int j = 0; j < numCourses; j++)
            {
                if (map.ContainsKey(i) && map[i].Contains(j))
                {
                    if (visited[j] == 1) return false;
                    if (visited[j] == 0)
                        if (!DFS(map, visited, j, numCourses, result)) return false;
                }
            }

            visited[i] = 2;
            result.Add(i);
            return true;
        }
    }
}
