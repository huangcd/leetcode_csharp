using System;
using System.Threading.Tasks;

namespace LeetCode.ExcelSheetColumnTitle
{
    public class Solution
    {
        public string ConvertToTitle(int n)
        {
            var k = 1;
            String result;
            while (!ConvertToTitle(n, k, out result))
            {
                n -= (int)Math.Pow(26, k);
                k += 1;
            }

            return result;
        }

        public bool ConvertToTitle(int n, int k, out string result)
        {
            if (n > Math.Pow(26, k))
            {
                result = null;
                return false;
            }
            var array = new char[k];
            n = n - 1;
            for (var i = 0; i < k; i++)
            {
                array[k - 1 - i] = (char)('A' + (n % 26));
                n /= 26;
            }
            result = new String(array);
            return true;
        }
    }
}
