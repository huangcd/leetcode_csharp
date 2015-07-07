using System.Collections.Generic;

namespace LeetCode.ContainsDuplicateII
{
    public class Solution
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            if (nums.Length == 0)
            {
                return false;
            }
            if (k == 0)
            {
                return false;
            }
            if (k < 0)
            {
                k = -k;
            }

            var slidingSet = new HashSet<int>();
            var reverseDict = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var v = nums[i];
                if (slidingSet.Contains(v))
                {
                    return true;
                }

                // maintain
                if (i >= k)
                {
                    var vToRemove = reverseDict[i - k];
                    reverseDict.Remove(i - k);
                    slidingSet.Remove(vToRemove);
                }

                slidingSet.Add(v);
                reverseDict[i] = v;
            }
            return false;
        }
    }
}