using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P206_ReverseLinkedList
{
    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode preNode =null;
            while (head != null)
            {
                var next = head.next;
                head.next = preNode;
                preNode = head;
      
                head = next;
            }
            return preNode;
        }
    }
}
