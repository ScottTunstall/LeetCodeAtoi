using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeAtoi
{
    public class Solution
    {
        private const int ASCII_FOR_ZERO = 48;
        public const int INT_MIN = -2147483648;

        public int MyAtoi(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return 0;

            var trimmed = str.Trim();
            int sign = 1;

            var firstChar = trimmed[0];
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

            for (int i=numberStart; i<trimmed.Length && trimmed[i]=='0'; i++)
                numberStart++;

            var numbers = new Stack<int>();
            for (int i= numberStart; i < trimmed.Length && char.IsDigit(trimmed[i]); i++)
            {
                numbers.Push(trimmed[i]-ASCII_FOR_ZERO);
            }

            if (numbers.Count == 0)
                return 0;

            if (numbers.Count > 10)
            {
                return sign == 1 ? Int32.MaxValue : Int32.MinValue;
            }

            long multiplier = 1;
            long result = 0;
            while (numbers.TryPop(out int value))
            {
                result += value * multiplier;

                if (result * sign < int.MinValue)
                    return int.MinValue;
                
                if (result * sign > int.MaxValue)
                    return int.MaxValue;

                multiplier *= 10;
            }

            return (int)result * sign;
        }
    };
}
