using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P981_TimeBasedKeyValueStore
{
    public class TimeMap
    {
        private Dictionary<string,SortedList<int,string>> _Dict;
        public TimeMap()
        {
            _Dict = new Dictionary<string, SortedList<int, string>>();
        }

        public void Set(string key, string value, int timestamp)
        {
            if (!_Dict.ContainsKey(key))
            {
                _Dict.Add(key, new SortedList<int, string>());
            }
            _Dict[key].Add(timestamp, value);
        }

        public string Get(string key, int timestamp)
        {
            if (!_Dict.ContainsKey(key))
            {
                return string.Empty;
            }
            var list = _Dict[key];
            for (var i = list.Count - 1; i >= 0; i--)
                if (list.Keys[i] <= timestamp)
                    return list.Values[i];
            

            return string.Empty;
        }
    }
}
