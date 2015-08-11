using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Anagrams
{
    public class Solution
    {
        public IList<string> Anagrams(string[] strs)
        {
            var primes = new[]
            {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101};
            return strs.GroupBy(s => s.Aggregate(1m, (n, c) => n * primes[(c - 'a')]))
                .Where(g => g.Count() > 1)
                .SelectMany(s => s)
                .ToList();
        }
    }
}