using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace LeetCode.ReverseNodesInKGroup.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void ReverseKGroupTest()
        {
            var sol = new Solution();
            Assert.AreEqual(53412, sol.ReverseKGroup(54321, 2));
            Assert.AreEqual(54123, sol.ReverseKGroup(54321, 3));
        }
    }
}

namespace LeetCode.GenerateParentheses.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void GenerateParenthesisTest()
        {
            var sol = new Solution();
            Assert.AreEqual(new[] { "((()))", "(()())", "(())()", "()(())", "()()()" },
                sol.GenerateParenthesis(3));
        }
    }
}

namespace LeetCode.MergeTwoSoretedLists.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void MergeTwoListsTest()
        {
            var sol = new Solution();
            Assert.AreEqual(54321, sol.MergeTwoLists(531, 42));
            Assert.AreEqual(54321, sol.MergeTwoLists(54321, null));
            Assert.AreEqual(54321, sol.MergeTwoLists(null, 54321));
        }
    }
}

namespace LeetCode.ValidParentheses.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void IsValidTest()
        {
            var sol = new Solution();
            Assert.IsTrue(sol.IsValid("()"));
            Assert.IsTrue(sol.IsValid("()[]{}"));
            Assert.IsTrue(sol.IsValid("()[({})]{}"));
            Assert.IsFalse(sol.IsValid("()[({(})]{}"));
            Assert.IsFalse(sol.IsValid("([)]"));
            Assert.IsFalse(sol.IsValid("(["));
            Assert.IsFalse(sol.IsValid("([]"));
            Assert.IsFalse(sol.IsValid("(){[]"));
        }
    }
}

namespace LeetCode.RemoveNthNodeFromEndOfList.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void RemoveNthFromEndTest()
        {
            var sol = new Solution();
            Assert.AreEqual(5321, sol.RemoveNthFromEnd(54321, 2));
            Assert.AreEqual(4321, sol.RemoveNthFromEnd(54321, 1));
        }
    }
}

namespace LeetCode.FourSum.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void FourSumTest()
        {
            var sol = new Solution();
            Assert.AreEqual(new[] { new[] { -2, -1, 1, 2 }, new[] { -2, 0, 0, 2 }, new[] { -1, 0, 0, 1 }, },
                sol.FourSum(new[] { 1, 0, -1, 0, -2, 2 }, 0));
        }
    }
}

namespace LeetCode.LetterCombinationsOfAPhoneNumber.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void LetterCombinationsTest()
        {
            var sol = new Solution();
            Assert.AreEqual(new[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" },
                sol.LetterCombinations("23"));
            Assert.AreEqual(new[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" },
                sol.LetterCombinations("23"));
        }
    }
}

namespace LeetCode
{
    public static class TestExtension
    {
        public static String Join<T>(
            this IEnumerable<T> enumerable,
            string separator = ",")
        {
            return String.Join(separator, enumerable.Select(e => e.ToString()));
        }

        public static String Join<T, K>(
            this IEnumerable<T> enumerable,
            string separator = ",",
            string open = "{",
            string close = "}") where T : IEnumerable<K>
        {
            return String.Join(separator, enumerable.Select(e => open + e.Join(separator) + close));
        }
    }
}

namespace LeetCode.ThreeSumClosest.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void ThreeSumClosestTest()
        {
            var sol = new Solution();
            Assert.AreEqual(2, sol.ThreeSumClosest(new[] { -1, 2, 1, -4 }, 1));
            Assert.AreEqual(3, sol.ThreeSumClosest(new[] { 0, 1, 2 }, 3));
            Assert.AreEqual(0, sol.ThreeSumClosest(new[] { 0, 0, 0 }, 3));
            Assert.AreEqual(1, sol.ThreeSumClosest(new[] { 1, 1, -1 }, 2));
        }
    }
}

namespace LeetCode.ThreeSum.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void ThreeSumTest()
        {
            var sol = new Solution();
            var expect = new List<IList<int>> { new[] { -1, -1, 2 }, new[] { -1, 0, 1 }, };
            var actual = sol.ThreeSum(new[] { -1, 0, 1, 2, -1, -4 });
            Assert.AreEqual(expect.Join<IList<int>, int>(), actual.Join<IList<int>, int>());
            expect = new List<IList<int>>();
            actual = sol.ThreeSum(new[] { 1, 2, 3, 4 });
            Assert.AreEqual(expect.Join<IList<int>, int>(), actual.Join<IList<int>, int>());
        }
    }
}

namespace LeetCode.LongestCommonPrefix.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void LongestCommonPrefixTest()
        {
            var sol = new Solution();
            Assert.AreEqual(String.Empty, sol.LongestCommonPrefix(null));
            Assert.AreEqual(String.Empty, sol.LongestCommonPrefix(new string[0]));
            Assert.AreEqual(String.Empty, sol.LongestCommonPrefix(new[] { null, "Hello world" }));
            Assert.AreEqual(String.Empty, sol.LongestCommonPrefix(new[] { "", "Hello world" }));
            Assert.AreEqual(String.Empty, sol.LongestCommonPrefix(new[] { "AC", "Hello world" }));
            Assert.AreEqual("He", sol.LongestCommonPrefix(new[] { "He", "Hello world" }));
            Assert.AreEqual("He", sol.LongestCommonPrefix(new[] { "He's a good boy", "Hello world" }));
        }
    }
}

namespace LeetCode.IntegerToRoman.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void IntToRomanTest()
        {
            var sol = new Solution();
            Assert.AreEqual("IV", sol.IntToRoman(4));
        }
    }
}

namespace LeetCode.ContainerWithMostWater.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void MaxAreaTest()
        {
            var sol = new Solution();
            Assert.AreEqual(1, sol.MaxArea(new[] { 1, 1 }));
            Assert.AreEqual(25, sol.MaxArea(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
            Assert.AreEqual(25, sol.MaxArea(new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }));
            Assert.AreEqual(25, sol.MaxArea(new[] { 1, 2, 3, 4, 5, 10, 9, 8, 7, 6 }));
            Assert.AreEqual(49, sol.MaxArea(new[] { 3, 1, 7, 9, 5, 10, 2, 6, 4, 8 }));
            Assert.AreEqual(72, sol.MaxArea(new[] { 9, 1, 7, 9, 10, 5, 2, 6, 4, 8 }));

            Assert.AreEqual(56250000, sol.MaxArea(Enumerable.Range(1, 15000).ToArray()));

            Assert.AreEqual(56250000, sol.MaxArea(Enumerable.Range(1, 15000).Reverse().ToArray()));
        }
    }
}

namespace LeetCode.RegularExpressionMatching.Tests
{
    [TestFixture]
    public class SolutionTests
    {
        [Test]
        public void IsMatchTest()
        {
            var sol = new Solution();
            Assert.AreEqual(false, sol.IsMatch("aa", "a"));
            Assert.AreEqual(true, sol.IsMatch("aa", "aa"));
            Assert.AreEqual(false, sol.IsMatch("aaa", "aa"));
            Assert.AreEqual(true, sol.IsMatch("aa", "a*"));
            Assert.AreEqual(true, sol.IsMatch("aa", ".*"));
            Assert.AreEqual(true, sol.IsMatch("ab", ".*"));
            Assert.AreEqual(true, sol.IsMatch("aab", "c*a*b"));
        }
    }
}

namespace LeetCode.PalindromeNumber.Tests
{
    [TestFixture]
    public class SolutionTests
    {
        [Test]
        public void IsPalindromeTest()
        {
            var sol = new Solution();
            Assert.False(sol.IsPalindrome(Int32.MaxValue));
            Assert.False(sol.IsPalindrome(Int32.MinValue));
            Assert.True(sol.IsPalindrome(Solution.MaxPalindromeNumber));
            Assert.False(sol.IsPalindrome(1000000003));
        }
    }
}

namespace LeetCode.StringToInteger.Tests
{
    [TestFixture]
    public class SolutionTests
    {
        [Test]
        public void MyAtoiTest()
        {
            var sol = new Solution();
            Assert.AreEqual(0, sol.MyAtoi(""));
            Assert.AreEqual(-12, sol.MyAtoi("  -0012a42"));
            Assert.AreEqual(0, sol.MyAtoi("+-2"));
            Assert.AreEqual(2147483647, sol.MyAtoi("2147483648"));
            Assert.AreEqual(0, sol.MyAtoi("   - 321"));
            Assert.AreEqual(2147483647, sol.MyAtoi("9223372036854775809"));
        }
    }
}

namespace LeetCode.ReverseInteger.Tests
{
    [TestFixture]
    public class SolutionTests
    {
        [Test]
        public void ReverseTest()
        {
            var sol = new Solution();
            Assert.AreEqual(321, sol.Reverse(123));
            Assert.AreEqual(-321, sol.Reverse(-123));
            Assert.AreEqual(0, sol.Reverse(1000000003));
            Assert.AreEqual(1, sol.Reverse(10));
        }
    }
}

namespace LeetCode.ZigZagConversion.Tests
{
    [TestFixture]
    public class SolutionTests
    {
        [Test]
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