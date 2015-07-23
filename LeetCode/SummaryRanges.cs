using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SummaryRanges
{
    public class Solution
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            if (nums.Length == 0)
            {
                return new List<string>();
            }
            if (nums.Length == 1)
            {
                return new List<string> { nums[0].ToString() };
            }
            return nums.Skip(1).Aggregate(new List<List<int>> { new List<int> { nums[0] } }, (l, n) =>
            {
                var lastList = l.LastItem();
                if (n - 1 == lastList.LastItem())
                {
                    lastList.Add(n);
                }
                else
                {
                    l.Add(new List<int> { n });
                }
                return l;
            })
            .Select(l =>
            {
                if (l.Count == 1)
                {
                    return l[0].ToString();
                }
                return String.Format("{0}->{1}", l[0], l.LastItem());
            })
            .ToList();

        }
    }

    public static class ListExtenstions
    {
        public static T LastItem<T>(this IList<T> list)
        {
            if (list == null)
            {
                throw new ArgumentNullException();
            }
            return list[list.Count - 1];
        }
    }
}