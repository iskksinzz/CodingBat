using System;

namespace Factorial
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Factorial(3));
            Console.ReadLine();
        }

        /* Given n of 1 or more, return the factorial of n.
         * Compute the result recursively (without loops). */
        public static int Factorial(int n)
        {
            return n == 1 ? n : n * Factorial(n - 1);
        }
    }
}
