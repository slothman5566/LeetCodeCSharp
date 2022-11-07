using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P039_CombinationSum
{
    public class Solution
    {
        private List<IList<int>> _Result;
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            _Result = new List<IList<int>>();
            DFS(candidates, new List<int>(), target);

            return _Result;
        }
        public void DFS(int[] candidates, List<int> list, int target)
        {
            if (target == 0)
            {

                _Result.Add(list);
                return;
            }
            foreach (var candidate in candidates)
            {
                
                if (candidate <= target )
                {
                    if(list.Count > 0 && (list.Last() >candidate ) )
                    {
                        continue;
                    }
                    
                    var tempList = new List<int>();

                    tempList.AddRange(list);


                    tempList.Add(candidate);

                    DFS(candidates, tempList, target - candidate);


                }
            }
        }
    }
}
