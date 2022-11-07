﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P019_RemoveNthNodeFromEndOfList
{
    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null || n <= 0) { return null; }

            ListNode fakeHead, node1, node2;
            fakeHead = new ListNode(-1);
            fakeHead.next = head;

            node1 = node2 = fakeHead;
            for (int i = 0; i < n; i++)
            {
                if (node1 == null) { return null; }
                node1 = node1.next;
            }

            if (node1 != null)
            {
                while (node1.next != null)
                {
                    node1 = node1.next;
                    node2 = node2.next;
                }
                node2.next = node2.next.next;
            }
            return fakeHead.next;
        }
    }
}
