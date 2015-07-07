namespace LeetCode.InvertBinaryTree
{
    public class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            var left = InvertTree(root.right);
            var right = InvertTree(root.left);
            root.left = left;
            root.right = right;
            return root;
        }
    }
}