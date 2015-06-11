using System.Linq;
using NUnit.Framework;

namespace LeetCode.BinarySearchTreeIterator.Tests
{
    [TestFixture()]
    public class BSTIteratorTests
    {
        [Test()]
        public void BSTIteratorTest()
        {
            var tree = (TreeNode) "1, #, 2";
            var sol = new BSTIterator(tree);
            Assert.AreEqual(new [] {1, 2}, sol.ToArray());
        }
    }
}
