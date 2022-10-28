using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P067_AddBinary
{
    public class Solution
    {
        public string AddBinary(string a, string b)
        {

            var i = a.Length - 1;
            var j = b.Length - 1;
            var carry = 0;
            var sb = string.Empty;
            while(i>=0 || j >= 0)
            {
                var sum = carry;
                if (i >= 0)
                {
                    sum += a[i] - '0';
                    i--;

                }

                if (j >= 0)
                {
                    sum += b[j] - '0';
                    j--;

                }
                sb=$"{sum % 2}{sb}";
                carry = sum / 2;
            }
            if (carry != 0)
            {
                sb = $"{carry}{sb}";
            }
            return sb.ToString();

        }
    }
}
