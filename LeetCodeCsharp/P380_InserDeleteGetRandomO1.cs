using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P380_InserDeleteGetRandomO1
{
    public class RandomizedSet
    {
        protected Dictionary<int, int> _Dict;
        protected List<int> _List;
        protected Random _Rand;

        public RandomizedSet()
        {
            _Dict = new Dictionary<int, int>();
            _List = new List<int>();
            _Rand = new Random();
        }

        public bool Insert(int val)
        {
            if (_Dict.ContainsKey(val))
            {
                return false;
            }
            _List.Add(val);
            _Dict.Add(val, _List.Count - 1);
            return true;
        }

        public bool Remove(int val)
        {
            if (!_Dict.ContainsKey(val))
            {
                return false;
            }
            var last = _List.Last();
            _Dict[last] = _Dict[val];
            _List[_Dict[val]] = last;
            _List.RemoveAt(_List.Count-1);
            _Dict.Remove(val);
            return true;
        }

        public int GetRandom()
        {
            return _List[_Rand.Next(0, _List.Count)];
        }
    }
}
