using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P134_GasStation
{
    public class Solution
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            var sum = 0;
            var index = 0;
            for (var i=0; i < gas.Length; i++)
            {
                sum += gas[i] - cost[i];
                gas[i] = gas[i] - cost[i];
                if (sum < 0)
                {
                    sum = 0;
                    index = i+1;
                }
            }

            return gas.Sum() < 0 ? -1 : index;
        }
    }
}
