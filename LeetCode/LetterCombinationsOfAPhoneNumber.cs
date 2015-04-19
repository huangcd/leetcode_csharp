using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LetterCombinationsOfAPhoneNumber
{
    public class Solution
    {
        private readonly static Dictionary<char, string> Numbers = new Dictionary<char, string>
        {
            {'2', "abc"},
            {'3', "def"},
            {'4', "ghi"},
            {'5', "jkl"},
            {'6', "mno"},
            {'7', "pqsr"},
            {'8', "tuv"},
            {'9', "wxyz"},
        };

        public IList<string> LetterCombinations(string digits)
        {
            IList<string> result = new List<string>();
            if (digits.Length == 0)
            {
                return result;
            }
            char[] buffer = new char[digits.Length];
            Combinations(digits, buffer, 0, result);
            return result;
        }

        private void Combinations(string digits, char[] buffer, int index, IList<string> result)
        {
            if (index == digits.Length)
            {
                result.Add(new String(buffer));
                return;
            }
            string chars = Numbers[digits[index]];
            foreach (var c in chars)
            {
                buffer[index] = c;
                Combinations(digits, buffer, index + 1, result);
            }
        }
    }
}
