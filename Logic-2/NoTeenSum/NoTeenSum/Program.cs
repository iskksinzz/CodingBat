using System;

namespace NoTeenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NoTeenSum(1, 2, 3));
            Console.WriteLine(NoTeenSum(2, 13, 1));
            Console.WriteLine(NoTeenSum(2, 1, 14));
            Console.ReadLine();
        }

        public static int NoTeenSum(int a, int b, int c)
        {
            return FixTeen(a) + FixTeen(b) + FixTeen(c);
        }

        public static int FixTeen(int n)
        {
            if (n == 15 || n == 16) { return n; }
            return (n >= 13 && n <= 19) ? 0 : n;
        }
    }
}
