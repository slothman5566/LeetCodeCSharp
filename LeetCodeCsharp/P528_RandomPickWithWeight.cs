using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P528_RandomPickWithWeight
{
    public class Solution
    {
        protected int[] _Sum;
        protected Random _Random;
        public Solution(int[] w)
        {
            _Sum = w;
            var acc = -1;
            _Sum = w.Select(x => acc += x).ToArray();

            _Random = new Random();
        }

        public int PickIndex()
        {
            int weight = _Random.Next(0, _Sum.Last() + 1);
            int index = Array.BinarySearch(_Sum, weight);
            return (index < 0) ? ~index : index;
        }
    }
}
