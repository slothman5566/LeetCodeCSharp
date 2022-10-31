using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P234_PalindromeLinkedList
{
    public class Solution
    {
        ListNode realHead;

        public bool IsPalindrome(ListNode head)
        {
            if (head == null)
                return true;

            if (realHead == null)
                realHead = head;

            bool result = true;

            if (head.next != null)
                result = result & IsPalindrome(head.next);


            result = result & (head.val == realHead.val);
            realHead = realHead.next;

            return result;
        }
    }
}
