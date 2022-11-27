using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P658_FindKClosestElements
{
    public class Solution
    {
        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            var list = arr.ToList();

            while (list.Count > k)
            {
                if (x - list.First() <=  list.Last()-x)
                {
                    list.RemoveAt(list.Count - 1);
                }
                else
                {
                    list.RemoveAt(0);
                }
            }

            return list.ToArray();
        }
    }
}
