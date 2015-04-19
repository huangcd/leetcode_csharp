using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.FourSum
{
    public class Solution
    {
        public IList<IList<int>> FourSum(int[] num, int target)
        {
            Array.Sort(num);
            var result = new List<IList<int>>();
            for (int i = 0, maxI = num.Length - 3; i < maxI; i++)
            {
                if (i > 0 && num[i] == num[i - 1])
                {
                    continue;
                }
                for (int j = i + 1, maxJ = num.Length - 2; j < maxJ; j++)
                {
                    if (j > i + 1 && num[j] == num[j - 1])
                    {
                        continue;
                    }
                    for (int k = j + 1, maxK = num.Length - 1; k < maxK; k++)
                    {
                        if (k > j + 1 && num[k] == num[k- 1])
                        {
                            continue;
                        }
                        var val = target-(num[i] + num[j] + num[k]);
                        var index = Array.BinarySearch(num, k + 1, num.Length - k - 1, val);
                        if (index > 0)
                        {
                            result.Add(new[] { num[i], num[j], num[k], val });
                        }
                    }
                }
            }
            return result;
        }
    }
}
