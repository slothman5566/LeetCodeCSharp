using System.Collections.Generic;
using System.Linq;

namespace LeetCodeCSharp.P0412_FizzBuzz

{
    public class Solution
    {
        protected HashSet<int> hash = new HashSet<int>() { 3, 5 };
        public IList<string> FizzBuzz(int n)
        {
            return Enumerable.Range(1, n).Select(x => x % 15 == 0 ? "FizzBuzz" : x % 3 == 0 ? "Fizz" : x % 5 == 0 ? "Buzz" : x.ToString()).ToArray();

        }
    }
}
