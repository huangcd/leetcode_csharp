using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.RemoveNthNodeFromEndOfList
{
    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var vHead = new ListNode(-1);
            vHead.next = head;
            var p = vHead;

            for (int i = 0; i < n; i++)
            {
                p = p.next;
            }

            var q = vHead;
            while (p.next != null)
            {
                p = p.next;
                q = q.next;
            }

            q.next = q.next.next;

            return vHead.next;
        }
    }
}
