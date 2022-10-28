using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P217_ContainsDuplicate
{
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var hashSet = new HashSet<int>();
            foreach(var n in nums)
            {
                if (hashSet.Contains(n))
                {
                    return true;
                }
                hashSet.Add(n);
            }
            return false;
           
        }
    }
}
