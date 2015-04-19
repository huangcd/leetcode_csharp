namespace LeetCode.ReverseNodesInKGroup
{
    public static class ListNodeExts
    {
        public static ListNode Reverse(this ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            var vHead = new ListNode(-1);
            var p = head;
            var q = p.next;
            while (q != null)
            {
                p.next = vHead.next;
                vHead.next = p;
                p = q;
                q = p.next;
            }

            p.next = vHead.next;
            vHead.next = p;

            return vHead.next;
        }
    }
}