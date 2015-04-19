using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.RotateArray
{
    public class Solution
    {
        public static int GreatestCommonDivisor(int a, int b)
        {
            if (a < b)
            {
                return GreatestCommonDivisor(b, a);
            }
            if (b == 0)
            {
                return a;
            }
            return GreatestCommonDivisor(b, a % b);
        }

        public void Rotate(int[] nums, int k)
        {
            int gcd = GreatestCommonDivisor(nums.Length, k);
            for (int offset = 0; offset < gcd; offset++)
            {
                int current = offset;
                int next = (current + k) % nums.Length;
                int value = nums[current];
                while (next != offset)
                {
                    int temp = nums[next];
                    nums[next] = value;
                    value = temp;
                    current = next;
                    next = (current + k) % nums.Length;
                }
                nums[offset] = value;
            }
        }
    }
}
