using System;
using System.Collections.Generic;

namespace LeetCode.ThreeSum
{
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] num)
        {
            Array.Sort(num);
            var result = new List<IList<int>>();
            for (int i = 0; i < num.Length; i++)
            {
                if (i > 0 && num[i] == num[i - 1])
                {
                    continue;
                }
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (j > i + 1 && num[j] == num[j - 1])
                    {
                        continue;
                    }
                    var target = -(num[i] + num[j]);
                    var index = Array.BinarySearch(num, j + 1, num.Length - j - 1, target);
                    if (index > 0)
                    {
                        result.Add(new[] { num[i], num[j], target });
                    }
                }
            }
            return result;
        }
    }
}