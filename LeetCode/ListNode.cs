using System.Threading;

namespace LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }

        public ListNode(int x, ListNode next)
        {
            val = x;
            this.next = next;
        }

        public static implicit operator int(ListNode node)
        {
            var result = 0;
            var pow = 1;
            while (node != null)
            {
                result += pow * node.val;
                pow *= 10;
                node = node.next;
            }
            return result;
        }

        public static implicit operator ListNode(int value)
        {
            var head = new ListNode(-1);
            var p = head;
            while (value != 0)
            {
                p.next = new ListNode(value % 10);
                value /= 10;
                p = p.next;
            }
            return head.next;
        }
    }
}
