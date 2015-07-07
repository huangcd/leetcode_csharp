using System;
using System.Collections.Generic;

namespace LeetCode.IsomorphicStrings
{
    public class Solution
    {
        public Boolean IsIsomorphic(String s, String t)
        {
            if (String.Equals(s, t))
            {
                return true;
            }
            if (s == null || t == null)
            {
                return false;
            }
            if (s.Length != t.Length)
            {
                return false;
            }
            var indices = new int[s.Length];

            // set indices
            {
                var dict = new Dictionary<char, int>();
                for (var i = 0; i < s.Length; i++)
                {
                    int currentIndex;
                    var c = s[i];
                    if (!dict.TryGetValue(c, out currentIndex))
                    {
                        currentIndex = i;
                        dict[c] = currentIndex;
                    }
                    indices[i] = currentIndex;
                }
            }

            // match indices
            {
                var dict = new Dictionary<char, int>();
                for (var i = 0; i < t.Length; i++)
                {
                    var c = t[i];
                    if (indices[i] == i)
                    {
                        if (dict.ContainsKey(c))
                        {
                            return false;
                        }
                        dict[c] = i;
                    }
                    else
                    {
                        if (!dict.ContainsKey(c) || dict[c] != indices[i])
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}