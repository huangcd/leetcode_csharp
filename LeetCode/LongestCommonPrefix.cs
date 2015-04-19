using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.LongestCommonPrefix
{
    public class Solution
    {
        public string LongestCommonPrefix(IList<string> strs)
        {
            if (strs == null || strs.Count == 0 || strs[0] == null)
            {
                return String.Empty;
            }

            var index = 0;
            while (strs.All(s => index < s.Length && s[index] == strs[0][index]))
            {
                index++;
            }
            return strs[0].Substring(0, index);
        }
    }
}