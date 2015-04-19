using System;

namespace LeetCode.DivideTwoIntegers
{
    public class Solution
    {
        public int Divide(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                return Int32.MaxValue;
            }
            if (divisor == 1)
            {
                return dividend;
            }
            if (divisor == -1)
            {
                return dividend == Int32.MinValue ? Int32.MaxValue : -dividend;
            }
            if (divisor == dividend)
            {
                return 1;
            }
            if (divisor == Int32.MinValue)
            {
                return 0;
            }
            if (dividend != Int32.MinValue && Math.Abs(divisor) > Math.Abs(dividend))
            {
                return 0;
            }
            var sign = Math.Sign(dividend)*Math.Sign(divisor);
            divisor = Math.Abs(divisor);
            // divisor == 2^k
            if (dividend == Int32.MinValue && (divisor & (divisor - 1)) == 0)
            {
                var i = 1;
                while (divisor << i != dividend)
                {
                    i ++;
                }
                return sign * (1 << i);
            }

            if (dividend == Int32.MinValue)
            {
                dividend += 1;
            }

            var val = 0;
            dividend = Math.Abs(dividend);
            while (dividend >= divisor)
            {
                var i = 1;
                while (divisor << i > 0 && divisor << i < dividend)
                {
                    i ++;
                }
                val += 1 << (i - 1);
                dividend -= divisor << (i - 1);
            }
            return sign * val;
        }
    }
}
