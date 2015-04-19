﻿using System.Collections.Generic;

namespace LeetCode.ValidParentheses
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            foreach (var c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' && (stack.Count == 0 || stack.Pop() != '('))
                {
                    return false;
                }
                else if (c == ']' && (stack.Count == 0 || stack.Pop() != '['))
                {
                    return false;
                }
                else if (c == '}' && (stack.Count == 0 || stack.Pop() != '{'))
                {
                    return false;
                }
            }
            return stack.Count == 0;
        }
    }
}