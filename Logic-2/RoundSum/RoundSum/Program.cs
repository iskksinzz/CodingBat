using System;

namespace RoundSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RoundSum(16, 17, 18));
            Console.WriteLine(RoundSum(12, 13, 14));
            Console.WriteLine(RoundSum(6, 4, 4));
            Console.ReadLine();
        }

        public static int RoundSum(int a, int b, int c)
        {
            return Round10(a) + Round10(b) + Round10(c);
        }

        private static int Round10(int n)
        {
            return n % 10 >= 5 ? ((n / 10) * 10 + 10) : ((n / 10) * 10);
        }
    }
}
