using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P692_TopKFrequentWords
{
    public class Solution
    {
        public IList<string> TopKFrequent(string[] words, int k)
        {
            var dict = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (!dict.ContainsKey(word))
                {
                    dict[word] = 0;
                }
                dict[word]++;
            }

            var list = new SortedList<(string, int), string>(Comparer<(string, int)>.Create((x,y) =>
            {
                if (x.Item2 == y.Item2)
                {
                   
                    return -y.Item1.CompareTo(x.Item1);
                }
                return y.Item2.CompareTo(x.Item2);
            }));
            foreach(var pair in dict)
            {
                list.Add((pair.Key, pair.Value), pair.Key);
            }

            return list.Values.Take(k).ToList();

        }


    }
}
