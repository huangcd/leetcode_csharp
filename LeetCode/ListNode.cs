using System.Collections;
using System.Collections.Generic;

namespace LeetCode
{
    public class ListNode : IEnumerable<int>
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
            while (node != null)
            {
                result = result * 10 + node.val;
                node = node.next;
            }
            return result;
        }

        public static implicit operator ListNode(int value)
        {
            var vHead = new ListNode(-1);
            while (value != 0)
            {
                var p = new ListNode(value % 10) { next = vHead.next };
                vHead.next = p;
                value /= 10;
            }

            return vHead.next;
        }

        public IEnumerator<int> GetEnumerator()
        {
            var p = this;
            do
            {
                yield return p.val;
                p = p.next;
            } while (p.next != null);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}