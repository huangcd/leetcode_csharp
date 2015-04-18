using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.StringToInteger
{
    public class Solution
    {
        private static bool LargeThanInt32Max(int current, int lastDigit)
        {
            return current > 214748364 || (current == 214748364 && lastDigit > 7);
        }

        public int MyAtoi(string str)
        {
            try
            {
                var sign = 1;
                var result = 0L;
                var hasSign = false;
                var start = false;
                foreach (var c in str)
                {
                    if (c == '-' && !start)
                    {
                        if (!hasSign)
                        {
                            sign *= -1;
                            hasSign = true;
                            start = true;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (c == '+' && !start)
                    {
                        if (!hasSign)
                        {
                            sign *= 1;
                            hasSign = true;
                            start = true;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (Char.IsSeparator(c) && !start)
                    {
                    }
                    else if (c >= '0' && c <= '9')
                    {
                        start = true;
                        var last = c - '0';
                        result = result * 10 + last;
                        if (result > Int32.MaxValue)
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                result = sign * result;
                if (result > Int32.MaxValue)
                {
                    return Int32.MaxValue;
                }
                else if (result < Int32.MinValue)
                {
                    return Int32.MinValue;
                }
                return (int)result;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
