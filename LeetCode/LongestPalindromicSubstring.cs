using System;
using System.Collections.Generic;

namespace LeetCode.LongestPalindromicSubstring
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            var maxLength = 0;
            var maxStart = -1;
            var stringLength = s.Length;
            for (int i = 0; i < stringLength; i++)
            {
                int backExclusive;
                int forwardExclusive;
                int length;
                backExclusive = i - 1;
                forwardExclusive = i + 1;
                while (true)
                {
                    if (backExclusive < 0 || forwardExclusive >= s.Length || s[backExclusive] != s[forwardExclusive])
                    {
                        break;
                    }
                    backExclusive--;
                    forwardExclusive++;
                }
                length = forwardExclusive - backExclusive - 1;
                if (length > maxLength)
                {
                    maxLength = length;
                    maxStart = backExclusive + 1;
                }


                backExclusive = i + 1;
                forwardExclusive = i;
                while (true)
                {
                    if (backExclusive >= s.Length || backExclusive < 0 || forwardExclusive >= s.Length || s[backExclusive] != s[forwardExclusive])
                    {
                        break;
                    }
                    backExclusive--;
                    forwardExclusive++;
                }
                length = forwardExclusive - backExclusive - 1;
                if (length > maxLength)
                {
                    maxLength = length;
                    maxStart = backExclusive + 1;
                }
            }

            return s.Substring(maxStart, maxLength);
        }
    }
}
