using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P046_Permutations
{
    public class Solution
    {
        private List<IList<int>> _Result;
        private void DFS(List<int> nums, List<int> list)
        {
            if (nums.Count == 0)
            {

                _Result.Add(list);
                return;
            }
            for(var i=0;i<nums.Count; i++)
            {
                var tempList = new List<int>();

                tempList.AddRange(list);


                tempList.Add(nums[i]);
                var exist = nums.ToList();
                exist.RemoveAt(i);
                DFS(exist, tempList);
            }
           
        }
        public IList<IList<int>> Permute(int[] nums)
        {
            _Result = new List<IList<int>>();
            DFS(nums.ToList(), new List<int>());

            return _Result;
        }
    }
}
