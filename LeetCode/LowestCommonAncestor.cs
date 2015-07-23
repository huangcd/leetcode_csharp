namespace LeetCode.LowestCommonAncestor
{
    public class Solution
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || p == null || q == null)
            {
                return null;
            }
            if (p == q)
            {
                return p;
            }
        }
    }
}