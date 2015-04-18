using System;

namespace LeetCode.ZigZagConversion
{
    public class Solution
    {
        public string Convert(String s, int n)
        {
            if (n == 1)
            {
                return s;
            }

            var buffer = new char[s.Length];
            var index = 0;
            // first row
            for (int i = 0, skip = (n - 1) * 2; i < s.Length; i += skip)
            {
                buffer[index ++] = s[i];
            }
            // middle rows
            for (int r = 1; r < n - 1; r++)
            {
                for (int i = r, skip = (n - 1) * 2; i < s.Length; i += skip)
                {
                    buffer[index++] = (s[i]);
                    var next = i + (n - r - 1) * 2;
                    if (next < s.Length)
                    {
                        buffer[index++] = (s[next]);
                    }
                }
            }
            // last row
            for (int i = n - 1, skip = (n - 1) * 2; i < s.Length; i += skip)
            {
                buffer[index++] = (s[i]);
            }
            return new String(buffer);
        }
    }
}
