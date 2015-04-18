using System;
using System.Linq;
using NUnit.Framework;
using LeetCode.LongestSubstringWithoutRepeatingCharacters;
using LeetCode.MedianOfTwoSortedArrays;
using LeetCode.LongestPalindromicSubstring;
using LeetCode.ZigZagConversion;
namespace LeetCode.ZigZagConversion.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void ConvertTest()
        {
            var sol = new Solution();
            Assert.AreEqual("PAHNAPLSIIGYIR", sol.Convert("PAYPALISHIRING", 3));
            Assert.AreEqual("A", sol.Convert("A", 1));
        }
    }
}

namespace LeetCode.LongestPalindromicSubstring.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void LongestPalindromeTest()
        {
            var sol = new Solution();
            Assert.AreEqual("abcdedcba", sol.LongestPalindrome("zzzzabcdedcbadddd"));
            Assert.AreEqual("abcddcba", sol.LongestPalindrome("zzzzabcddcbadddd"));
            Assert.AreEqual("abcddcba", sol.LongestPalindrome("abcddcba"));
            Assert.AreEqual("abcdedcba", sol.LongestPalindrome("abcdedcba"));
        }
    }
}

namespace LeetCode.MedianOfTwoSortedArrays.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void FindMedianSortedArraysTest()
        {
            var sol = new Solution();
            var random = new Random();
            var source = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            for (var i = 0; i <= source.Length; i++)
            {
                var randomSource = source.OrderBy(random.Next).ToArray();
                var left = randomSource.Take(i).OrderBy(n => n).ToArray();
                var right = randomSource.Skip(i).OrderBy(n => n).ToArray();
                var actual = sol.FindMedianSortedArrays(left, right);
                Assert.AreEqual(
                    4.5,
                    actual,
                    1E-6,
                    String.Format("{3}: Except 4.5, but actual median([{0}], [{1}]) = {2}",
                                  String.Join(",", left.Select(n => n.ToString())),
                                  String.Join(", ", right.Select(n => n.ToString())),
                                  actual,
                                  i));
            }
            source = new[] { 1, 2, 3, 3, 5, 6, 7 };
            for (var i = 0; i <= source.Length; i++)
            {
                var randomSource = source.OrderBy(random.Next).ToArray();
                var left = randomSource.Take(i).OrderBy(n => n).ToArray();
                var right = randomSource.Skip(i).OrderBy(n => n).ToArray();
                var actual = sol.FindMedianSortedArrays(left, right);
                Assert.AreEqual(
                    3,
                    actual,
                    1E-6,
                    String.Format("{3}: Except 3, but actual median([{0}], [{1}]) = {2}",
                                  String.Join(",", left.Select(n => n.ToString())),
                                  String.Join(", ", right.Select(n => n.ToString())),
                                  actual,
                                  i));
            }
        }
    }
}

namespace LeetCode.LongestSubstringWithoutRepeatingCharacters.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void LengthOfLongestSubstringTest()
        {
            var sol = new Solution();
            Assert.AreEqual(3, sol.LengthOfLongestSubstring("abcabcbb"));
            Assert.AreEqual(1, sol.LengthOfLongestSubstring("bbb"));
        }
    }
}

namespace LeetCode.AddTwoNumber.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void AddTwoNumbersTest()
        {
            var solution = new Solution();
            Assert.AreEqual(807, solution.AddTwoNumbers(342, 465));
            Assert.AreEqual(100000000, solution.AddTwoNumbers(99999999, 1));
            Assert.AreEqual(100000000, solution.AddTwoNumbers(1, 99999999));
        }
    }
}

namespace LeetCode.TwoSum.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void TwoSumTest()
        {
            var solution = new Solution();
            Assert.AreEqual(Tuple.Create(1, 2), solution.TwoSum(new[] { 2, 7, 9, 15 }, 9));
            Assert.AreEqual(Tuple.Create(2, 3), solution.TwoSum(new[] { 3, 2, 4 }, 6));
        }
    }
}
