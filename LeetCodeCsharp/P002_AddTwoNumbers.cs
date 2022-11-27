using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P002_AddTwoNumbers
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
           
            var list1 = new List<int>();
            var list2 = new List<int>();

            while (l1 != null)
            {
                list1.Add(l1.val);
              
                l1 = l1.next;
            }

            while (l2 != null)
            {
                list2.Add(l2.val);
               
                l2 = l2.next;
            }

            var count = Math.Max(list1.Count, list2.Count);
            var reslutList = new List<int>();
            var leading = 0;
            for (var i=0; i < count; i++)
            {
                var temp = 0;
                if (i < list1.Count)
                {
                    temp += list1[i];
                }

                if (i < list2.Count)
                {
                    temp += list2[i];
                }
                temp += leading;
                if (temp / 10 > 0)
                {
                    leading = 1;
                    temp = temp % 10;
                }
                else { leading = 0; }
                reslutList.Add(temp);

            }
            if (leading == 1)
            {
                reslutList.Add(leading);
            }
            var nodeList = reslutList.Select(x => new ListNode(x)).ToList();
            for (var i = 0; i < reslutList.Count - 1; i++)
            {
                nodeList[i].next = nodeList[i + 1];
            }
            return nodeList.First();
           
        }
    }
}
