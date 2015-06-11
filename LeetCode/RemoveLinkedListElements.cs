namespace LeetCode.RemoveLinkedListElements
{
    public class Solution
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            var vHead = new ListNode(-1) { next = head };
            var p = vHead;
            while (p.next != null)
            {
                if (p.next.val == val)
                {
                    p.next = p.next.next;
                }
                else
                {
                    p = p.next;
                }
            }
            return vHead.next;
        }
    }
}
