using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P146_LRUCache
{
    public class LRUCache
    {
        private int _Capacity;
        private Dictionary<int, (LinkedListNode<int> node, int value)> _Cache;
        private LinkedList<int> _List;

        public LRUCache(int capacity)
        {
            _Capacity = capacity;
            _Cache = new Dictionary<int, (LinkedListNode<int> node, int value)>(capacity);
            _List = new LinkedList<int>();
        }

        public int Get(int key)
        {
            if (!_Cache.ContainsKey(key))
                return -1;

            var node = _Cache[key];
            _List.Remove(node.node);
            _List.AddFirst(node.node);

            return node.value;
        }

        public void Put(int key, int value)
        {
            if (_Cache.ContainsKey(key))
            {
                var node = _Cache[key];
                _List.Remove(node.node);
                _List.AddFirst(node.node);

                _Cache[key] = (node.node, value);
            }
            else
            {
                if (_Cache.Count >= _Capacity)
                {
                    var removeKey = _List.Last.Value;
                    _Cache.Remove(removeKey);
                    _List.RemoveLast();
                }

                // add cache
                _Cache.Add(key, (_List.AddFirst(key), value));
            }
        }
    }
}
