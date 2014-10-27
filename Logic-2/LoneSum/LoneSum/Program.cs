using System;

namespace LoneSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LoneSum(1, 2, 3));
            Console.WriteLine(LoneSum(3, 2, 3));
            Console.WriteLine(LoneSum(3, 3, 3));
            Console.ReadLine();
        }

        public static int LoneSum(int a, int b, int c)
        {
            return a == b && b == c ? 0 : (a == b ? c : (b == c ? a : (a == c ? b : a + b + c)));
        }
    }
}
