using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P021_MergeTwoSortedLists
{

    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode result=new ListNode();
            ListNode next = result;

            while ((list1 != null && list2 != null))
            {
                if (list1.val < list2.val)
                {
                    next.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    next.next = list2;
                    list2 = list2.next;
                }
                next = next.next;
            } ;
            if (list1 != null)
            {
                next.next = list1;
            }
            if (list2 != null)
            {
                next.next = list2;
            }
            return result.next;
        }
    }
}
