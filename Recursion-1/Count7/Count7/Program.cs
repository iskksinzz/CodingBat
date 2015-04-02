using System;

namespace Count7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Count7(717));
            Console.ReadLine();
        }

        public static int Count7(int n)
        {
            return n == 0 ? 0 : n % 10 == 7 ? 1 + Count7(n / 10) : Count7(n / 10);
        }
    }
}
