using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumDigits(126));
            Console.ReadLine();
        }

        public static int SumDigits(int n)
        {
            return n == 0 ? 0 : SumDigits(n / 10) + n % 10;
        }
    }
}
