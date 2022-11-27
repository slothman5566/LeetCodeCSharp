using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P148_SortList
{
    public class Solution
    {
        public ListNode SortList(ListNode head)
        {
            if(head==null || head.next == null)
            {
                return head;
            }

            ListNode fast=head.next, slow=head;
            while(fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            var mid = slow.next;
            slow.next = null;
            return Merge(SortList(head), SortList(mid));
        }

        protected ListNode Merge(ListNode left,ListNode right)
        {
            var head = new ListNode();
            var current = head;
            while(left!=null && right != null)
            {
                if (left.val < right.val)
                {
                    current.next = left;
                    left = left.next;
                }
                else
                {
                    current.next = right;
                    right = right.next;
                }
                current = current.next;
            }
            current.next = left == null ? right : left;
            return head.next;
        }
    }
}
