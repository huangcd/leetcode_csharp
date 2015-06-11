using System;
using System.Collections.Generic;
using System.Linq;
using Parseq;

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
            return String.Format("{0}, {1}, {2}",
                val,
                left == null ? "#" : left.ToString(),
                right == null ? "#" : right.ToString());
        }

        public static implicit operator String(TreeNode node)
        {
            return node == null ? "" : node.ToString();
        }

        public static TreeNode Parse(String str)
        {
            var tokens = str.Split(new[] { ',', ' ', '{', '}' }, StringSplitOptions.RemoveEmptyEntries).AsEnumerable();
            return Parse(ref tokens);
        }

        private static TreeNode Parse(ref IEnumerable<String> tokens)
        {
            var enumerable = tokens as string[] ?? tokens.ToArray();
            if (enumerable.Length == 0)
            {
                return null;
            }
            var current = enumerable.First();
            tokens = enumerable.Skip(1);
            if (current == "#")
            {
                return null;
            }
            var val = Int32.Parse(current);
            var node = new TreeNode(val) { left = Parse(ref tokens), right = Parse(ref tokens) };
            return node;
        }

        public static implicit operator TreeNode(String str)
        {
            return Parse(str);
        }
    }
}
