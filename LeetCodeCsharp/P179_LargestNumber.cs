using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P179_LargestNumber
{
    public class Solution
    {
        public string LargestNumber(int[] nums)
        {
            var list = nums.ToList() ;
            list.Sort((x, y) => (y.ToString() + x.ToString()).CompareTo(x.ToString()+y.ToString()));
            var result = string.Empty;
            foreach(var num in list)
            {
                result += num.ToString();
            }

            return result[0] == '0' ? "0" : result;
        }
    }
}
