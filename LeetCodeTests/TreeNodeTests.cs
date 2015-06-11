using System;
using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture()]
    public class TreeNodeTests
    {
        [Test()]
        public void ToStringTest()
        {
            var tree = new TreeNode(1);
            Assert.AreEqual("1, #, #", (String)tree);
            tree.left = new TreeNode(2);
            Assert.AreEqual("1, 2, #, #, #", (String)tree);
            tree.left.left = new TreeNode(3);
            Assert.AreEqual("1, 2, 3, #, #, #, #", (String)tree);
            tree.right = new TreeNode(4);
            Assert.AreEqual("1, 2, 3, #, #, #, 4, #, #", (String)tree);
        }

        [Test()]
        public void FromStringTest()
        {
            Assert.AreEqual("1, #, 2, #, #", (String)(TreeNode)"1, #, 2");
        }
    }
}
