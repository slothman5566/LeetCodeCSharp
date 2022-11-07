using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P049_GroupAnagrams
{
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dict = new Dictionary<string, List<string>>();

            foreach (var str in strs)
            {
                
              var result=  string.Concat( str.OrderBy(x=>x));

                if (!dict.ContainsKey(result))
                {
                    dict.Add(result, new List<string>());
                 
                }
                dict[result].Add(str);
            }

            return dict.Select(x=>(IList<string>)x.Value).ToList();
        }
    }
}
