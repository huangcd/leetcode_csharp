using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ReverseInteger
{
    public class Solution
    {
        public int Reverse(int x)
        {
            if (x == Int32.MinValue)
            {
                // Overflow
                return 0;
            }
            int newVal = 0;
            int sign = x > 0 ? 1 : -1;
            x = x * sign;
            while (x != 0)
            {
                var last = x % 10;
                if (LargeThanInt32Max(newVal, last))
                {
                    return 0;
                }
                newVal = newVal * 10 + x % 10;
                x /= 10;
            }
            return newVal * sign;
        }

        private static bool LargeThanInt32Max(int current, int lastDigit)
        {
            return current > 214748364 || (current == 214748364 && lastDigit > 7);
        }
    }
}
