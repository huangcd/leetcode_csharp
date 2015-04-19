using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.IntegerToRoman
{
    public class Solution
    {
        public string IntToRoman(int num)
        {
            return new String(YieldRoman(num).ToArray());
        }

        public static IEnumerable<char> YieldRoman(int num)
        {
            while (num >= 1000)
            {
                yield return 'M';
                num -= 1000;
            }
            while (num >= 900)
            {
                yield return 'C';
                yield return 'M';
                num -= 900;
            }
            while (num >= 500)
            {
                yield return 'D';
                num -= 500;
            }
            while (num >= 400)
            {
                num -= 400;
                yield return 'C';
                yield return 'D';
            }
            while (num >= 100)
            {
                yield return 'C';
                num -= 100;
            }
            while (num >= 90)
            {
                num -= 90;
                yield return 'X';
                yield return 'C';
            }
            while (num >= 50)
            {
                num -= 50;
                yield return 'L';
            }
            while (num >= 40)
            {
                num -= 40;
                yield return 'X';
                yield return 'L';
            }
            while (num >= 10)
            {
                yield return 'X';
                num -= 10;
            }
            while (num >= 9)
            {
                num -= 9;
                yield return 'I';
                yield return 'X';
            }
            while (num >= 5)
            {
                num -= 5;
                yield return 'V';
            }
            while (num >= 4)
            {
                num -= 4;
                yield return 'I';
                yield return 'V';
            }
            while (num != 0)
            {
                yield return 'I';
                num -= 1;
            }
        }
    }
}