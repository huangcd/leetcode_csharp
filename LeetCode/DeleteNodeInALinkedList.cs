namespace LeetCode.DeleteNodeInALinkedList
{
    public class Solution
    {
        public void DeleteNode(ListNode node)
        {
            if (node.next == null)
            {
                return;
            }
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}