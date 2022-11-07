using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P078_Subsets
{
    public class Solution
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            var count= Math.Pow(2, nums.Length);

            var result = new List<IList<int>>();
            for(var i=0;i< count; i++)
            {
                var j = i;
                var tempList = new List<int>();
                var index = 1;
                while (j > 0)
                {
                    if ((j & 1 )>0)
                    {
                        tempList.Add(nums[nums.Length - index]);
                    }
                    index++;
                    j = j >> 1;
                }

                result.Add(tempList);
            }
            return result;
        }

        public IList<IList<int>> SubsetsByDFS(int[] nums)
        {
            var result = new List<IList<int>>();
            DFS(nums, 0, new List<int>(), result);
            return result;
        }

        protected void DFS(int[] nums,int pos,List<int> list, List<IList<int>> result)
        {
            result.Add(list.ToList());
            for(var i = pos; i < nums.Length; i++)
            {
                list.Add(nums[i]);
                DFS(nums, i + 1, list, result);
                list.RemoveAt(list.Count - 1);

            }
        }
    }
}
