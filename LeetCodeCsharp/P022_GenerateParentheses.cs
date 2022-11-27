using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P022_GenerateParentheses
{
    public class Solution
    {
        public IList<string> GenerateParenthesis(int n)
        {
            var result = new List<string>();
            DFS(result,n, n, string.Empty);
            return result;
                
        }

        protected void DFS(IList<string> list,int left,int right,string result)
        {
            if(left==0 && right == 0)
            {
                list.Add(result);
                return;
            }

            if (left > 0)
            {
                DFS(list, left - 1, right, result + '(');
            }
            if (left < right)
            {
                DFS(list, left , right-1, result + ')');
            }
        }
    }
}
