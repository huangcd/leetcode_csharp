using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.MergeIntervals
{
    public class Solution
    {
        public IList<Interval> Merge(IList<Interval> intervals)
        {
            if (intervals == null || intervals.Count <= 1)
            {
                return intervals;
            }
            var orderIntervals = intervals.OrderBy(i => i.end).ThenBy(i => i.start).ToList();
            var result = new List<Interval>();
            var index = 0;
            var interval = orderIntervals[index++];
            for (; index < orderIntervals.Count; )
            {
                var current = orderIntervals[index];
                if (current.start <= interval.end)
                {
                    interval = new Interval(Math.Min(interval.start, current.start), current.end);
                    index++;
                }
                else
                {
                    result.Add(interval);
                    index++;
                    interval = current;
                }
            }
            result.Add(interval);

            return result;
        }
    }
}
