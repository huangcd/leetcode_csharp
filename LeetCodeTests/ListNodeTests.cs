using LeetCode.ReverseNodesInKGroup;
using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture()]
    public class ListNodeTests
    {
        [Test()]
        public void ListNodeTest()
        {
            ListNode left = 324;
            ListNode right = 465;
            int leftVal = left;
            int rightVal = right;
            Assert.AreEqual(324, leftVal);
            Assert.AreEqual(465, rightVal);
            Assert.AreEqual(12345, ((ListNode)54321).Reverse());
            Assert.AreEqual(1, ((ListNode)1).Reverse());
            Assert.AreEqual(null, ((ListNode)null).Reverse());
        }
    }
}