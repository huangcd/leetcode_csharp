using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.NumberOf1Bits
{
    public class Solution
    {
        public int HammingWeight(uint n)
        {
            var result = 0;
            while (n != 0)
            {
                n = n & (n - 1);
                result += 1;
            }
            return result;
        }
    }
}
