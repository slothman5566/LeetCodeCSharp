using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P121_BestTimetoBuyandSellStock
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            var profit = 0;
            if (prices.Length < 2)
            {
                return 0;
            }
            var min = prices[0];
            for(var i=1;i<prices.Length; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                }

                if (prices[i] - min > profit)
                {
                    profit = prices[i] - min;
                }
            }
           
            return profit;
        }
    }
}
