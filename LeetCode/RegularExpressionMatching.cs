using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.RegularExpressionMatching
{
    using System.Text.RegularExpressions;
    public class Solution
    {
        public bool IsMatch(string s, string p)
        {
            var regex = new Regex("^" + p + "$");
            return regex.IsMatch(s);
        }
    }
}
