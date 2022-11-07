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
                var temp = split.Trim();
                if (split.Contains("["))
                {
                    temp = temp.Substring(1);
                    result.Add(new List<int>());
                }
                if (split.Contains(']'))
                {
                    temp = temp.Substring(0, temp.Length - 1);
                }
                var n = 0;
                if(int.TryParse(temp,out n))
                {
                    result.Last().Add(n);
                }
              
             
            }
            return result.Select(x => x.ToArray()).ToArray();
        }

        public static char[][] ConvertStringToCharArrayOfArrays(string input)
        {
            var result = new List<List<char>>();
            var splits = input.Split(',');
            foreach (var split in splits)
            {
                var temp = split.Trim();
                if (split.Contains("["))
                {
                    temp = temp.Substring(1);
                    result.Add(new List<char>());
                }
                if (split.Contains(']'))
                {
                    temp = temp.Substring(0, temp.Length - 1);
                }
                if (split.Contains('\''))
                {
                    temp = temp.Substring(1);
                    temp = temp.Substring(0, temp.Length - 1);
                }
                char n ;
                if (char.TryParse(temp, out n))
                {
                    result.Last().Add(n);
                }


            }
            return result.Select(x => x.ToArray()).ToArray();
        }
    }
}
