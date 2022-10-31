using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetCodeCSharp.P133_CloneGraph;
using System.Linq;
using System.Collections.Generic;
namespace LeetCodeCSharp.Test
{
    [TestClass]
    public class P133_CloneGraph
    {
        Solution _Solution = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            var node1 = new Node(1);
            var node2 = new Node(2);
            var node3 = new Node(3);
            var node4 = new Node(4);
            node1.neighbors.Add(node2);
            node1.neighbors.Add(node4);

            node2.neighbors.Add(node1);
            node2.neighbors.Add(node3);

            node3.neighbors.Add(node2);
            node3.neighbors.Add(node4);

            node4.neighbors.Add(node1);
            node4.neighbors.Add(node3);

            var ans = _Solution.CloneGraph(node1);
        }
    }
}
