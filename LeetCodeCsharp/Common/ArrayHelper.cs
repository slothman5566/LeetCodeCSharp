using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{

    public class ArrayHelper
    {
        public static int[][] ConvertStringToIntArrayOfArrays(string input)
        {
            var result = new List<List<int>>();
            var splits = input.Split(',');
            foreach (var split in splits)
            {
                var temp = split;
                if (split.Contains("["))
                {
                    temp = split.Substring(1);
                    result.Add(new List<int>());
                }
                else if (split.Contains(']'))
                {
                    temp = split.Substring(0, split.Length - 1);
                }
                result.Last().Add(Convert.ToInt32(temp));
            }
            return result.Select(x => x.ToArray()).ToArray();
        }
    }
}
