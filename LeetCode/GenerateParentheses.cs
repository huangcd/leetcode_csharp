using System;
using System.Collections.Generic;

namespace LeetCode.GenerateParentheses
{
    public class Solution
    {
        public IList<string> GenerateParenthesis(int n)
        {
            var result = new List<string>();
            if (n == 0)
            {
                return result;
            }
            var buffer = new char[n * 2];
            Generate(buffer, n, n, 0, result);
            return result;
        }

        private void Generate(char[] buffer, int open, int close, int index, IList<string> result)
        {
            if (open == 0 && close == 0)
            {
                result.Add(new String(buffer));
                return;
            }
            if (open > 0)
            {
                buffer[index] = '(';
                Generate(buffer, open - 1, close, index + 1, result);
            }
            if (open < close)
            {
                buffer[index] = ')';
                Generate(buffer, open, close - 1, index + 1, result);
            }
        }
    }
}