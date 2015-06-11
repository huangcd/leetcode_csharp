using System.Collections;
using System.Collections.Generic;

namespace LeetCode.BinarySearchTreeIterator
{
    public class BSTIterator : IEnumerable<int>
    {
        private readonly Stack<TreeNode> _stack;
        private TreeNode _current;
        private readonly TreeNode _root;

        public BSTIterator(TreeNode root)
        {
            _stack = new Stack<TreeNode>();
            _root = root;
            Reset();
        }

        private void PushLeft()
        {
            while (_current != null)
            {
                _stack.Push(_current);
                _current = _current.left;
            }
            _current = _stack.Peek();
        }

        private void MoveToNext()
        {
            if (_stack.Count == 0)
            {
                _current = null;
                return;
            }

            var parent = _stack.Peek();
            // Left tree visiting finished, next is parent
            if (parent.left == _current)
            {
                _current = parent;
            }
            // Parent visiting finished, next is leftmost in right tree
            else if (parent == _current && parent.right != null)
            {
                _current = parent.right;
                PushLeft();
            }
            // Right tree visisting finished, next is parent's parent
            else
            {
                _current = parent;
                _stack.Pop();
                MoveToNext();
            }
        }

        /** @return whether we have a next smallest number */
        public bool HasNext()
        {
            return _current != null;
        }

        /** @return the next smallest number */
        public int Next()
        {
            var result = _current.val;
            MoveToNext();
            return result;
        }

        public IEnumerator<int> GetEnumerator()
        {
            Reset();
            while (HasNext())
            {
                yield return Next();
            }
            Reset();
        }

        private void Reset()
        {
            _current = _root;
            PushLeft();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
