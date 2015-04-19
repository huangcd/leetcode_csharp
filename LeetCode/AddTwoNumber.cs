namespace LeetCode.AddTwoNumber
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var head = new ListNode(-1);
            var p = head;
            var carry = 0;
            while (l1 != null || l2 != null)
            {
                var val = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + carry;
                p.next = new ListNode(val % 10);
                carry = val / 10;
                p = p.next;
                l1 = (l1 == null ? null : l1.next);
                l2 = (l2 == null ? null : l2.next);
            }
            if (carry != 0)
            {
                p.next = new ListNode(1);
            }
            return head.next;
        }
    }
}