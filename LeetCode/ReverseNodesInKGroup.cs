namespace LeetCode.ReverseNodesInKGroup
{
    public class Solution
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if (head == null)
            {
                return null;
            }
            var vHead = new ListNode(-1)
            {
                next = head
            };
            var p = vHead;
            var q = p;
            var h = vHead;

            while (q != null && p != null && head != null)
            {
                int index;
                for (index = 0; index < k && p.next != null; index++)
                {
                    p = p.next;
                }
                if (index != k)
                {
                    return vHead.next;
                }
                q = p.next;
                p.next = null;
                p = h.next;
                h.next = p.Reverse();
                head.next = q;
                h = head;
                p = head;
                q = head;
                head = head.next;
            }

            return vHead.next;
        }
    }
}