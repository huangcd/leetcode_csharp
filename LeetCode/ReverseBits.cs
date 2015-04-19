using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ReverseBits
{
    public class Solution
    {
        public uint reverseBits(uint n)
        {
            var result = 0u;
            for (var i = 31; i >= 0; i--)
            {
                result |= (n & 1) << i;
                n >>= 1;
            }
            return result;
        }
    }
}
