using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.MergeTwoSoretedLists
{
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var head = new ListNode(-1);
            var p = head;
            while (l1 != null || l2 != null)
            {
                if (l1 == null)
                {
                    p.next = l2;
                    break;
                }
                if (l2 == null)
                {
                    p.next = l1;
                    break;
                }
                if (l1.val <= l2.val)
                {
                    p.next = l1;
                    p = l1;
                    l1 = l1.next;
                    
                }
                else
                {
                    p.next = l2;
                    p = l2;
                    l2 = l2.next;
                }
            }
            return head.next;
        }
    }
}
