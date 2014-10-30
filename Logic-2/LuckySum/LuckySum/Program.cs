using System;

namespace LuckySum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LuckySum(1, 2, 3));
            Console.WriteLine(LuckySum(1, 2, 13));
            Console.WriteLine(LuckySum(1, 13, 3));
            Console.ReadLine();
        }

        public static int LuckySum(int a, int b, int c)
        {
            return a == 13 ? 0 : b == 13 ? a : c == 13 ? a + b : a + b + c;
        }
    }
}
