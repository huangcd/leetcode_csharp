using System.Collections.Generic;
using System.Linq;

namespace LeetCode.BinaryTreeRightSideView
{
    public class Solution
    {
        public IList<int> RightSideView(TreeNode root)
        {
            var result = new List<int>();
            if (root == null)
            {
                return result;
            }
            var nodes = new List<TreeNode> { root };
            while (nodes.Count != 0)
            {
                result.Add(nodes[nodes.Count - 1].val);
                nodes = nodes.SelectMany(node => new List<TreeNode> { node.left, node.right })
                             .Where(node => node != null)
                             .ToList();
            }
            return result;
        }
    }
}
