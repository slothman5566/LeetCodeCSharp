using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P287_FindTheDuplicateNumber
{
    public class Solution
    {
        public int FindDuplicate(int[] nums)
        {


            return nums.GroupBy(x => x).Where(x=>x.Count()>1).First().Key;
        }
    }
}
