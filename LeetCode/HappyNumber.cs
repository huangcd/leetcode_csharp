using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HappyNumber
{
    public class Solution
    {
        public bool IsHappy(int n)
        {
            var squares = Enumerable.Range(0, 10).ToDictionary(i => i, i => i * i);
            if (n == 1)
            {
                return true;
            }
            var set = new HashSet<int>();
            while (n != 1)
            {
                if (set.Contains(n))
                {
                    return false;
                }
                set.Add(n);
                var m = n;
                n = 0;
                while (m != 0)
                {
                    n += squares[m % 10];
                    m /= 10;
                }
            }
            return true;
        }
    }
}
