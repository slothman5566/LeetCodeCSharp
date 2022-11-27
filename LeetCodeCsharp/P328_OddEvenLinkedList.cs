using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P328_OddEvenLinkedList
{
    public class Solution
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode odd = head, even = head.next, even_head = even;

            while(even!=null && even.next != null)
            {
                odd.next = even.next;
                odd = odd.next;

                even.next = odd.next;
                even = even.next;
                

            }
            odd.next = even_head;
            return head;
        }
    }
}
