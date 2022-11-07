using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P075_SortColors
{
    public class Solution
    {
        public void SortColors(int[] nums)
        {

            var array = new int[3];
            foreach(var n in nums)
            {
                array[n]++;
            }
            var cur = 0;
            for (var i = 0; i < 3; i++)
            {
               
                for (int j = 0; j < array[i]; j++)
                {
                    nums[cur] = i;
                    cur++;
                }
            }
          
        }

    }
}
