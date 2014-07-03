using System;

namespace FizzArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FizzArray(4));
            Console.WriteLine(FizzArray(1));
            Console.WriteLine(FizzArray(10));
            Console.ReadLine();
        }

        /* Given a number n, create and return a new int array of length n,
         * containing the numbers 0, 1, 2, ... n-1.  */
        public static int[] FizzArray(int n)
        {
            var result = new int[n];
            for (var i = 0; i < n; i++)
            {
                result[i] = i;
            }
            return result;
        }
    }
}
