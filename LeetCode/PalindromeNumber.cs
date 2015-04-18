using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.PalindromeNumber
{
    public class Solution
    {
        public const int MaxPalindromeNumber = 2147447412;
        public bool IsPalindrome(int x)
        {
            if (x == Int32.MinValue)
            {
                return false;
            }
            if (x < 0)
            {
                return false;
            }
            if (x > MaxPalindromeNumber)
            {
                return false;
            }
            int palindrome;
            if (Reverse(x, out palindrome))
            {
                return palindrome == x;
            }
            return false;
        }

        private static bool Reverse(int x, out int result)
        {
            result = 0;
            if (x == Int32.MinValue)
            {
                // Overflow
                return false;
            }
            int newVal = 0;
            int sign = x > 0 ? 1 : -1;
            x = x * sign;
            while (x != 0)
            {
                var last = x % 10;
                if (LargeThanInt32Max(newVal, last))
                {
                    return false;
                }
                newVal = newVal * 10 + x % 10;
                x /= 10;
            }
            result = newVal * sign;
            return true;
        }

        private static bool LargeThanInt32Max(int current, int lastDigit)
        {
            return current > 214748364 || (current == 214748364 && lastDigit > 7);
        }
    }
}
