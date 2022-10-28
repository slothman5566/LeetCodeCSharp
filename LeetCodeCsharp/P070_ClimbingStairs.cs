using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P070_ClimbingStairs
{
    public class Solution
    {
        public int ClimbStairs(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            if (n == 2)
            {
                return 2;
            }
            
            return ClimbStairs(n - 1) + ClimbStairs(n - 2);


        }



    }
}
