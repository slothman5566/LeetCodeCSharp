using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P091_DecodeWays
{
    public class Solution
    {
        public int NumDecodings(string s)
        {
            var dp = new int[s.Length + 1];
            dp[0] = 1;
            for(var i=1; i < dp.Length; i++)
            {
                dp[i] = (s[i - 1] == '0') ? 0 : dp[i - 1];
                if (i > 1 && (s[i - 2] == '1' || (s[i - 2] == '2' && s[i - 1] <= '6')))
                {
                    dp[i] += dp[i - 2];
                }
            }
            return dp.Last();

        }
    }
}
