using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P310_MinimumHeightTrees
{
    public class Solution
    {
        public IList<int> FindMinHeightTrees(int n, int[][] edges)
        {
            if (n == 1)
            {
                return new int[] { 0 };
            }
            var result = new List<int>();

            var adjList = Enumerable.Range(0, n).Select(x => new HashSet<int>()).ToList();
            var queue = new Queue<int>();
            foreach (var edge in edges)
            {
                adjList[edge.First()].Add(edge.Last());
                adjList[edge.Last()].Add(edge.First());
            }
            for(var i=0; i < n; i++)
            {
                if (adjList[i].Count == 1)
                {
                    queue.Enqueue(i);
                }
            }
            while (n > 2)
            {
                var count = queue.Count;
                n -= count;
                for(var i=0;i<count; i++)
                {
                    var index = queue.Dequeue();
                    foreach(var set in adjList[index])
                    {
                        adjList[set].Remove(index);
                        if (adjList[set].Count == 1)
                        {
                            queue.Enqueue(set);
                        }
                    }
                }

            }
            if (queue.Count > 0)
            {
                result.AddRange(queue);
            }
            return result;
        }
    }
}
