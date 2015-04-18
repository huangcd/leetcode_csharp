using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LongestSubstringWithoutRepeatingCharacters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var lastPositions = new Dictionary<char, int>();
            int size = 0;
            int startPosition = -1;
            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i];
                int lastPosition;
                if (lastPositions.TryGetValue(c, out lastPosition) && lastPosition > startPosition)
                {
                    startPosition = lastPosition;
                }
                else
                {
                    size = Math.Max(size, i - startPosition);
                }
                lastPositions[c] = i;
            }
            return size;
        }
    }
}
