using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P268_MissingNumber
{
    public class Solution
    {
        public int MissingNumber(int[] nums)
        {
          
        
            return ((nums.Length + 1) * nums.Length / 2) - nums.Sum();
        }
    }
}
