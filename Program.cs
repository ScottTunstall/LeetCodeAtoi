using System;
using System.Diagnostics;

namespace LeetCodeAtoi
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            var solution = new Solution();

            result = solution.MyAtoi("    +0a32");
            Debug.Assert(result==0);

            result = solution.MyAtoi("");
            Debug.Assert(result == 0);

            result = solution.MyAtoi("    ");
            Debug.Assert(result == 0);

            result = solution.MyAtoi("a12345");
            Debug.Assert(result == 0);

            result = solution.MyAtoi("12345");
            Debug.Assert(result == 12345);

            result = solution.MyAtoi("3.14159");
            Debug.Assert(result == 3);

            result = solution.MyAtoi("+12345");
            Debug.Assert(result == 12345);

            result = solution.MyAtoi("-12345");
            Debug.Assert(result == -12345);

            result = solution.MyAtoi("-");
            Debug.Assert(result == 0);

            result = solution.MyAtoi("+");
            Debug.Assert(result == 0);

            result = solution.MyAtoi("+");
            Debug.Assert(result == 0);

            result = solution.MyAtoi("-91283472332");
            Debug.Assert(result == int.MinValue);

            result = solution.MyAtoi("-10000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000522545459");
            Debug.Assert(result == int.MinValue);

            result = solution.MyAtoi("    0000000000000   ");
            Debug.Assert(result == 0);

            result = solution.MyAtoi("+");
            Debug.Assert(result == 0);

        }
    }
}
