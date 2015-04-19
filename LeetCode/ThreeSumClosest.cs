using System;

namespace LeetCode.ThreeSumClosest
{
    public class Solution
    {
        public int ThreeSumClosest(int[] num, int target)
        {
            Array.Sort(num);
            var min = Int32.MaxValue;
            var result = 0;
            for (int i = 0; i < num.Length - 2; i++)
            {
                if (i > 0 && num[i] == num[i - 1])
                {
                    continue;
                }
                for (int j = i + 1; j < num.Length - 1; j++)
                {
                    if (j > i + 1 && num[j] == num[j - 1])
                    {
                        continue;
                    }
                    var n = target - (num[i] + num[j]);
                    var index = Array.BinarySearch(num, j + 1, num.Length - j - 1, n);
                    if (index >= j + 1)
                    {
                        return target;
                    }
                    else
                    {
                        index = ~index;
                        if (index - 1 > j && min > Math.Abs(n - num[index - 1]))
                        {
                            result = num[i] + num[j] + num[index - 1];
                            min = Math.Abs(n - num[index - 1]);
                        }
                        if (index < num.Length && min > Math.Abs(n - num[index]))
                        {
                            result = num[i] + num[j] + num[index];
                            min = Math.Abs(n - num[index]);
                        }
                    }
                }
            }
            return result;
        }
    }
}