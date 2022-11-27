using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P074_SearchA2DMatrix
{
    public class Solution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            var m = matrix.Length;
            var n = matrix[0].Length;

            for (var i = 0; i < m; i++)
            {
               
                if (target == matrix[i].First() || target == matrix[i].Last())
                {
                    return true;
                }
                if (target > matrix[i].First() && target < matrix[i].Last() && Array.BinarySearch(matrix[i],target)>0)
                {

                    return true;

                }
            }
            return false;

        }
    }
}
