using System;
using System.Linq;

namespace LeetCode.CountPrimes
{
    public class Solution
    {
        public int CountPrimes(int n)
        {
            if (n <= 1)
            {
                return 0;
            }
            var notPrime = new bool[n];
            notPrime[0] = true;
            notPrime[1] = true;
            for (int i = 2, max = (int)Math.Sqrt(n - 1); i <= max; i++)
            {
                if (notPrime[i])
                {
                    continue;
                }
                for (var j = i + i; j < n; j += i)
                {
                    notPrime[j] = true;
                }
            }
            return notPrime.Count(b => !b);
        }
    }
}