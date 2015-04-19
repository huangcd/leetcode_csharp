using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.ContainerWithMostWater
{
    public class Solution
    {
        private struct Item
        {
            public int Index;
            public int Height;

            public static Item Create(int index, int height)
            {
                return new Item { Index = index, Height = height };
            }
        }

        public int MaxArea(IList<int> height)
        {
            var reverseCandidate = new List<Item>();
            var currentMax = -1;
            for (var i = height.Count - 1; i >= 0; i--)
            {
                if (height[i] <= currentMax)
                {
                    continue;
                }
                reverseCandidate.Add(Item.Create(i, height[i]));
                currentMax = height[i];
            }

            var candidate = new List<Item>();
            currentMax = -1;
            for (var i = 0; i < height.Count; i++)
            {
                if (height[i] <= currentMax)
                {
                    continue;
                }
                candidate.Add(Item.Create(i, height[i]));
                currentMax = height[i];
            }

            return (from t1 in reverseCandidate
                    from t2 in candidate
                    where t1.Index > t2.Index
                    select Math.Min(t1.Height, t2.Height) * (t1.Index - t2.Index))
                    .Max();
        }
    }
}