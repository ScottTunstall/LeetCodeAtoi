using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeAtoi
{
    public class Solution
    {
        const int ASCII_FOR_ZERO = 48;

        public int myAtoi(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return 0;

            var trimmed = str.Trim();
            var firstChar = trimmed[0];
            int sign = 1;
            int numberStart = 0;
            if (firstChar == '-')
            {
                numberStart = 1;
                sign = -1;
            }

            if (firstChar == '+')
            {
                numberStart = 1;
            }

            var numbers = new Stack<int>();
            for (int i= numberStart; i < trimmed.Length && char.IsDigit(trimmed[i]); i++)
            {
                numbers.Push(trimmed[i]-ASCII_FOR_ZERO);
            }

            int multiplier = 1;
            int result = 0;
            while (numbers.TryPop(out int value))
            {
                result += value * multiplier;
                multiplier *= 10;
            }

            return result * sign;
        }
    };
}
