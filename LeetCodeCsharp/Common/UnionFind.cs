using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class UnionFind
    {
        private int[] _Parents;
        private int _Count;

        public UnionFind(int capacity)
        {
            this._Count = capacity;
            _Parents = Enumerable.Range(0, capacity).ToArray();
        }

        public int Find(int index)
        {
            if (_Parents[index] != index)
                _Parents[index] = Find(_Parents[index]);

            return _Parents[index];
        }

        public void Union(int index1, int index2)
        {
            var p1 = Find(index1);
            var p2 = Find(index2);

            if (p1 != p2)
            {
                _Parents[p1] = p2;
              
                _Count--;
            }
        }

        public int Count()
        {
            return _Count;
        }
    }
}
