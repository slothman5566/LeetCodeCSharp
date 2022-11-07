using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P017_LetterCombinationsOfAPhoneNumber
{
    public class Solution
    {
        protected Dictionary<char, char[]> _Dict = new Dictionary<char, char[]>()
        {
            { '0',new char[]{ ' '} },
            { '1',new char[]{ } },
            { '2',new char[]{ 'a','b','c'} },
            { '3',new char[]{ 'd', 'e', 'f' } },
            { '4',new char[]{ 'g', 'h', 'i' } },
            { '5',new char[]{ 'j', 'k', 'l' } },
            { '6',new char[]{ 'm', 'n', 'o' } },
            { '7',new char[]{ 'p', 'q', 'r','s' } },
            { '8',new char[]{ 't', 'u', 'v' } },
            { '9',new char[]{ 'w', 'x', 'y' ,'z'} },
        };
        public IList<string> LetterCombinations(string digits)
        {
            List<string> result = new List<string>();
            if (string.IsNullOrEmpty(digits)) {
                return result;
            }
           
            DFS(result, 0, string.Empty, digits);
            return result;
        }

        protected void DFS(List<string> result,int index,string current,string digits)
        {
            if(index== digits.Length)
            {
                result.Add(current);
                return;
            }

            foreach(var c in _Dict[digits[index]])
            {
                current += c;
                DFS(result, index + 1, current, digits);
                current=current.Remove(current.Length - 1);
            }
        }
    }
}
