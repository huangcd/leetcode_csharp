using System;
using System.Collections.Generic;

namespace LeetCode.TwoSum
{
    public class Solution
    {
        public Tuple<int, int> TwoSum(int[] numbers, int target)
        {
            var positions = new Dictionary<int, int>();
            for (var i = 0; i < numbers.Length; i++)
            {
                int position;
                if (positions.TryGetValue(numbers[i], out position))
                {
                    return Tuple.Create(position + 1, i + 1);
                }
                positions[target - numbers[i]] = i;
            }
            return Tuple.Create(0, 0);
        }
    }
}