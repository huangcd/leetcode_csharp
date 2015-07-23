using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using LeetCode.SummaryRanges;
namespace LeetCode.SummaryRanges.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void SummaryRangesTest()
        {
            var sol = new Solution();
            Assert.AreEqual(new List<String> { "0->2", "4->5", "7" }, sol.SummaryRanges(new[] { 0, 1, 2, 4, 5, 7 }));
        }
    }
}

namespace LeetCode.MergeIntervals.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void MergeTest()
        {
            var sol = new Solution();
            Assert.AreEqual(new[] { new Interval(1, 5) }, sol.Merge(new[] { new Interval(1, 5), new Interval(1, 4) }));
            Assert.AreEqual(new[] { new Interval(1, 6) }, sol.Merge(new[] { new Interval(1, 6), new Interval(2, 3), new Interval(4, 5), }));
        }
    }
}

namespace LeetCode.CountPrimes.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void CountPrimesTest()
        {
            var sol = new Solution();
            Assert.AreEqual(0, sol.CountPrimes(2));
            Assert.AreEqual(1, sol.CountPrimes(3));
            Assert.AreEqual(2, sol.CountPrimes(4));
            Assert.AreEqual(2, sol.CountPrimes(5));
            Assert.AreEqual(3, sol.CountPrimes(6));
        }
    }
}

namespace LeetCode.ContainsDuplicateII.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void ContainsNearbyDuplicateTest()
        {
            var sol = new Solution();
            Assert.IsFalse(sol.ContainsNearbyDuplicate(new[] { 1, 2, 1 }, 1));
        }
    }
}

namespace LeetCode.IsomorphicStrings.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void IsIsomorphicTest()
        {
            var sol = new Solution();
            Assert.IsTrue(sol.IsIsomorphic("pee", "lee"));
            Assert.IsTrue(sol.IsIsomorphic("add", "egg"));
            Assert.IsFalse(sol.IsIsomorphic("foo", "bar"));
            Assert.IsTrue(sol.IsIsomorphic("paper", "title"));
        }
    }
}

namespace LeetCode.ExcelSheetColumnTitle.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void ConvertToTitleTest()
        {
            var sol = new Solution();
            Assert.AreEqual("AB", sol.ConvertToTitle(28));
        }
    }
}

namespace LeetCode.HouseRobber.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void RobTest()
        {
            var sol = new Solution();
            Assert.AreEqual(2, sol.Rob(new[] { 1, 1, 1 }));
        }
    }
}

namespace LeetCode.RemoveLinkedListElements.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void RemoveElementsTest()
        {
            var sol = new Solution();
            Assert.AreEqual(12345, sol.RemoveElements(1236456, 6));
            Assert.AreEqual(null, sol.RemoveElements(666666, 6));
            Assert.AreEqual(12345, sol.RemoveElements(1236456, 6));
            Assert.AreEqual(12345, sol.RemoveElements(123456, 6));
            Assert.AreEqual(12345, sol.RemoveElements(612345, 6));
        }
    }
}

namespace LeetCode.HappyNumber.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void IsHappyTest()
        {
            var sol = new Solution();
            Assert.IsTrue(sol.IsHappy(19));
            Assert.IsTrue(sol.IsHappy(1));
            Assert.IsFalse(sol.IsHappy(2));
        }
    }
}

namespace LeetCode.ReverseBits.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void reverseBitsTest()
        {
            var sol = new Solution();
            Assert.AreEqual(964176192u, sol.reverseBits(43261596u));
            Assert.AreEqual(43261596u, sol.reverseBits(964176192u));
        }
    }
}

namespace LeetCode.RotateArray.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void RotateTest()
        {
            var sol = new Solution();
            var actual = new[] { 1, 2, 3, 4, 5, 6, 7 };
            sol.Rotate(actual, 3);
            Assert.AreEqual(new[] { 5, 6, 7, 1, 2, 3, 4 }, actual);

            actual = new[] { 1, 2, 3, 4, 5, 6, 7 };
            sol.Rotate(actual, 1);
            Assert.AreEqual(new[] { 7, 1, 2, 3, 4, 5, 6 }, actual);

            actual = new[] { 1, 2, 3, 4, 5, 6, 7 };
            sol.Rotate(actual, 0);
            Assert.AreEqual(new[] { 1, 2, 3, 4, 5, 6, 7 }, actual);
        }

        [Test()]
        public void GreatestCommonDivisorTest()
        {
            Assert.AreEqual(2, Solution.GreatestCommonDivisor(12, 14));
            Assert.AreEqual(2, Solution.GreatestCommonDivisor(12, 22));
            Assert.AreEqual(4, Solution.GreatestCommonDivisor(12, 16));
            Assert.AreEqual(3, Solution.GreatestCommonDivisor(12, 15));
            Assert.AreEqual(1, Solution.GreatestCommonDivisor(12, 17));
            Assert.AreEqual(1, Solution.GreatestCommonDivisor(12, 35));
        }
    }
}

namespace LeetCode.NumberOf1Bits.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void HammingWeightTest()
        {
            var sol = new Solution();
            Assert.AreEqual(3, sol.HammingWeight(11));
        }
    }
}

namespace LeetCode.DivideTwoIntegers.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        // [Timeout(100)]
        public void DivideTest()
        {
            var sol = new Solution();
            var random = new Random();
            Assert.AreEqual(Int32.MaxValue, sol.Divide(1, 0));
            Assert.AreEqual(Int32.MaxValue, sol.Divide(Int32.MaxValue, 0));
            Assert.AreEqual(0, sol.Divide(0, Int32.MaxValue));
            Assert.AreEqual(-1, sol.Divide(Int32.MinValue, Int32.MaxValue));
            Assert.AreEqual(-2, sol.Divide(Int32.MinValue, Int32.MaxValue / 2));
            Assert.AreEqual(-1, sol.Divide(1, -1));
            for (var i = 0; i < 10; i++)
            {
                var dividend = random.Next() * (random.Next(2) == 0 ? -1 : 1);
                var divisor = random.Next() * (random.Next(2) == 0 ? -1 : 1);
                Assert.AreEqual(dividend / divisor, sol.Divide(dividend, divisor), "Expect: {0} / {1} = {2}", dividend, divisor, dividend / divisor);
            }
        }
    }
}

namespace LeetCode.ImplementStrStr.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void StrStrTest()
        {
            var sol = new Solution();
            Assert.AreEqual(0, sol.StrStr("Hello World", "Hello"));
            Assert.AreEqual(6, sol.StrStr("Hello World ", "World"));
            Assert.AreEqual(6, sol.StrStr("Hello World", "World"));
            Assert.AreEqual(-1, sol.StrStr("Hello World", "World!"));
        }
    }
}

namespace LeetCode.ReverseNodesInKGroup.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void ReverseKGroupTest()
        {
            var sol = new Solution();
            Assert.AreEqual(21435, sol.ReverseKGroup(12345, 2));
            Assert.AreEqual(32145, sol.ReverseKGroup(12345, 3));
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
            Assert.AreEqual(12345, sol.MergeTwoLists(135, 24));
            Assert.AreEqual(12345, sol.MergeTwoLists(12345, null));
            Assert.AreEqual(12345, sol.MergeTwoLists(null, 12345));
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
            Assert.AreEqual(1235, sol.RemoveNthFromEnd(12345, 2));
            Assert.AreEqual(1234, sol.RemoveNthFromEnd(12345, 1));
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
            Assert.AreEqual(708, solution.AddTwoNumbers(243, 564));
            Assert.AreEqual(1, solution.AddTwoNumbers(99999999, 1));
            Assert.AreEqual(1, solution.AddTwoNumbers(1, 99999999));
            Assert.AreEqual(11111111, solution.AddTwoNumbers(11111111, 99999999));
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