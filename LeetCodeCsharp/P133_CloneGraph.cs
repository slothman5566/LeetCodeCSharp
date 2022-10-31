using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P133_CloneGraph
{
    public class Solution
    {
        protected Dictionary<int, Node> _NodeDict = new Dictionary<int, Node>();
        public Node CloneGraph(Node node)
        {
            if (node == null)
            {
                return null;
            }
            Queue<Node> nodes = new Queue<Node>();
            nodes.Enqueue(node);
            _NodeDict.Add(node.val, new Node(node.val));
            var curNode= _NodeDict[node.val];
           
            while (nodes.Count > 0)
            {
                var parent = nodes.Dequeue();
                foreach (var neighbor in parent.neighbors)
                {
                    
                    if (!_NodeDict.ContainsKey(neighbor.val))
                    {
                        nodes.Enqueue(neighbor);
                        _NodeDict.Add(neighbor.val, new Node(neighbor.val));
                    }
                    
                    _NodeDict[parent.val].neighbors.Add(_NodeDict[neighbor.val]);
                }
               
            }
            //Node curNode;
            //if (!_NodeDict.TryGetValue(node.val, out curNode))
            //{
            //    curNode = new Node(node.val);
            //    _NodeDict.Add(node.val, curNode);
            //    foreach(var neighbor  in node.neighbors)
            //    {
            //        curNode.neighbors.Add(CloneGraph(neighbor));
            //    }
            //}
            return curNode;
        }

    }
}
