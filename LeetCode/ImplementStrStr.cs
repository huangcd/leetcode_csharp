using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ImplementStrStr
{
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            for (int i = 0, max = haystack.Length - needle.Length; i <= max; i++)
            {
                var match = true;
                for (int j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
