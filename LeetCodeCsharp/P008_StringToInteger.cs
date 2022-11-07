using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P008_StringToInteger
{
    public class Solution
    {
        public int MyAtoi(string str)
        {
            if (string.IsNullOrWhiteSpace(str)) { return 0; }

            var navigate = false;
            var index = 0;

            while (index < str.Length && str[index] == ' ') { index++; }

            if (str[index] == '-')
            {
                navigate = true;
                index++;
            }
            else if (str[index] == '+')
            {
                index++;
            }

            var positiveOverflowHead = int.MaxValue / 10;
            var positiveOverflowTail = int.MaxValue % 10;

            var result = 0;
            for (; index < str.Length; index++)
            {
                var digit = str[index] - '0';
                if (digit < 0 || digit > 9) { break; }

                if (result > positiveOverflowHead ||
                    (result == positiveOverflowHead && digit > positiveOverflowTail))
                {
                    return navigate ? int.MinValue : int.MaxValue;
                }

                result = result * 10 + digit;
            }

            return navigate ? -result : result;
        }
    }
}
