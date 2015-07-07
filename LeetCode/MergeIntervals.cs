using System.Collections.Generic;
using System.Linq;

namespace LeetCode.MergeIntervals
{
    public class Solution
    {
        public IList<Interval> Merge(IList<Interval> intervals)
        {
            var orderIntervals = intervals.OrderByDescending(i => i.end).GetEnumerator();
            var result = new List<Interval>();

            while (orderIntervals.MoveNext())
            {
                
            }
        }
    }
}
