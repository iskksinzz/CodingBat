using System;

namespace Count8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Count8(8));
            Console.WriteLine(Count8(818));
            Console.WriteLine(Count8(8818));
            Console.ReadLine();
        }

        public static int Count8(int n)
        {
            if (n == 0)
                return 0;

            int num = n / 10;
            int add = 1;

            if (num % 10 == 8)
                add = 2;

            return n % 10 == 8 ? Count8(n / 10) + add : Count8(n / 10);
        }

    }
}
