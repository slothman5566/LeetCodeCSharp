using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.P141_LinkedListCycle
{
    public class Solution
    {
        public bool HasCycle(ListNode head)
        {
            var slowNode = head;
            var fastNode = head;
           
            while (slowNode != null && fastNode!=null && fastNode.next!=null)
            {
                slowNode = slowNode.next;
                fastNode = fastNode.next.next;
                if (slowNode == fastNode)
                {
                    return true;
                }
              
            }
            return false;
        }
    }
}
