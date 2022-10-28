using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
   public class ListNode
    {
        public int val;
        public ListNode next=null;
        public ListNode() { }
        public ListNode(int x) { val = x;}
        public ListNode(int x,ListNode next) { val = x;this.next = next; }

        public static ListNode BuildListNode(List<int> list)
        {
            var nodeList = list.Select(x => new ListNode(x)).ToList() ;
            for(var i=0;i<list.Count-1 ; i++)
            {
                nodeList[i].next = nodeList[i + 1];
            }
            return nodeList.First();
        }

        public static List<int> ConvertListNodeToList( ListNode node)
        {
            var list = new List<int>();
            while (node != null)
            {
                list.Add(node.val);
                node = node.next;
            }

            return list;
        }

    }
}
