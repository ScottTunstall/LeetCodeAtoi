using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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

            if (numberStart>=trimmed.Length || !char.IsDigit(trimmed[numberStart]))
                return 0;

            for (int i=numberStart; i<trimmed.Length && trimmed[i]=='0'; i++)
                numberStart++;

            // if the string is all zeroes then numberStart will exceed trimmed.Length
            if (numberStart >= trimmed.Length)
                return 0;

            if (!char.IsDigit(trimmed[numberStart]))
                return 0;

            int numberEnd=numberStart;
            for (int i = numberStart+1; i < trimmed.Length && char.IsDigit(trimmed[i]); i++)
            {
                numberEnd=i;
            }

            //var numbers = new Stack<int>();
            //for (int i= numberStart; i < trimmed.Length && char.IsDigit(trimmed[i]); i++)
            //{
            //    numbers.Push(trimmed[i]-ASCII_FOR_ZERO);
            //}

            if (numberEnd - numberStart > 10)
            {
                return sign == 1 ? int.MaxValue : int.MinValue;
            }

            long multiplier = 1;
            long result = 0;

            for (int i = numberEnd; i >= numberStart; i--)
            {
                result += (trimmed[i] - ASCII_FOR_ZERO) * multiplier;

                if (result * sign < int.MinValue)
                    return int.MinValue;

                if (result * sign > int.MaxValue)
                    return int.MaxValue;

                multiplier *= 10;
            }


            //long multiplier = 1;
            //long result = 0;
            //while (numbers.TryPop(out int value))
            //{
            //    result += value * multiplier;

            //    if (result * sign < int.MinValue)
            //        return int.MinValue;
                
            //    if (result * sign > int.MaxValue)
            //        return int.MaxValue;

            //    multiplier *= 10;
            //}

            return (int)result * sign;
        }
    };
}
