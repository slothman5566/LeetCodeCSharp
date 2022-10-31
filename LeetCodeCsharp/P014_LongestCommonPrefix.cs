using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P014_LongestCommonPrefix
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return string.Empty;
            }
            if (strs.Length == 1)
            {
                return strs[0];
            }
            string pre = strs[0];

            int i = 1;

            while (i < strs.Length)
            {
                while (strs[i].IndexOf(pre) != 0)
                    pre = pre.Substring(0, pre.Length - 1);
                i++;
            }
            //var result = FindLCP(strs[0], strs[1]);
            //if (result == string.Empty)
            //{
            //    return string.Empty;
            //}
            //for(var i=2; i < strs.Length; i++)
            //{
            //    result = FindLCP(strs[i], result);
            //    if (result == string.Empty)
            //    {
            //        return string.Empty;
            //    }
            //}
            return  pre;
        }

        public string FindLCP(string first,string second)
        {
            var i = 0;
           
            var count = -1;
            while(i<first.Length && i < second.Length)
            {
                if (first[i] == second[i])
                {
                    count = i+1;
                }
                else
                {
                    break;
                }
                i++;

            }
            return count > 0 ? first.Substring(0, count) : "";
        }
    }
}
