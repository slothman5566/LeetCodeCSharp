using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P207_CourseSchedule
{
    public class Solution
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            var graph = new bool[numCourses, numCourses];

            foreach (var prerequisite in prerequisites)
                graph[prerequisite[1], prerequisite[0]] = true;

            var visited = new int[numCourses];
            for (int i = 0; i < numCourses; i++)
                if (!DFS(graph, visited, i, numCourses)) return false;
            return true;
        }

        private bool DFS(bool[,] graph, int[] visited, int i, int numCourses)
        {
            // 1 => impossible
            if (visited[i] == 1) return false;
            // 2 => possible
            if (visited[i] == 2) return true;
            visited[i] = 1;
            for (int j = 0; j < numCourses; j++)
            {
                if (graph[i, j])
                {
                    if (visited[j] == 1) return false;
                    if (visited[j] == 0)
                        if (!DFS(graph, visited, j, numCourses)) return false;
                }
            }

            visited[i] = 2;
            return true;
        }

    }
}
