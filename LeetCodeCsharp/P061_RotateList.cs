using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P061_RotateList
{
    public class Solution
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (k == 0 || head == null || head.next == null)
            {
                return head;
            }
            var current = head;
            var prev = head;
            var count = 1;
            while (current.next != null)
            {
                prev = current;
                current = current.next;
                count++;
            }
            if (k > count)
            {
                k = k % count;
            }
            if (k == 0)
            {
                return head;
            }
            prev.next = null;
            current.next = head;
            return RotateRight(current, --k);
        }
    }
}
