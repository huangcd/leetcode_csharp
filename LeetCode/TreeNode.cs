using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }

        public override string ToString()
        {
            return String.Format("{0}, [{1}, {2}]", 
                val, 
                left == null ? "" : left.ToString(),
                right == null ? "" : right.ToString());
        }

        public static implicit operator String(TreeNode node)
        {
            return node == null ? "" : node.ToString();
        }

        public static implicit operator TreeNode(String str)
        {

        }
    }
}
