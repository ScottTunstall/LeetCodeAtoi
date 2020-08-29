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

            result = solution.myAtoi("");
            Debug.Assert(result == 0);

            result = solution.myAtoi("    ");
            Debug.Assert(result == 0);

            result = solution.myAtoi("a12345");
            Debug.Assert(result == 0);
            
            result = solution.myAtoi("12345");
            Debug.Assert(result == 12345);

            result = solution.myAtoi("+12345");
            Debug.Assert(result == 12345);

            result = solution.myAtoi("-12345");
            Debug.Assert(result == -12345);



        }
    }
}
