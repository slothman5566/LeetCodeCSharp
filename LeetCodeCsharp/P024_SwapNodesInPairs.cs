using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P024_SwapNodesInPairs
{
    public class Solution
    {
        public ListNode SwapPairs(ListNode head)
        {
            if(head==null || head.next == null)
            {
                return head;
            }
            var next = head.next;
            head.next = SwapPairs(head.next.next);
            next.next = head;
            return next;
        }
    }
}
