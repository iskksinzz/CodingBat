using System;

namespace PowerN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PowerN(3, 3));
            Console.ReadLine();
        }

        private static int PowerN(int n, int exponent)
        {
            return exponent == 1 ? n : n * PowerN(n, exponent - 1);
        }
    }
}
