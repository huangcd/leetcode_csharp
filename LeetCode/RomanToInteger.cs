using System.Collections.Generic;

namespace LeetCode.RomanToInteger
{
    public class Solution
    {
        private static readonly Dictionary<char, int> RomanMapping = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };

        public int RomanToInt(string s)
        {
            int size = s.Length;
            int result = 0;
            for (int i = 0, max = size - 1; i < max; i++)
            {
                int current = RomanMapping[s[i]];
                if (current >= RomanMapping[s[i + 1]])
                {
                    result += current;
                }
                else
                {
                    result -= current;
                }
            }
            result += RomanMapping[s[size - 1]];
            return result;
        }
    }
}