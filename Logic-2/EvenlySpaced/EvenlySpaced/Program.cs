using System;

namespace EvenlySpaced
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EvenlySpaced(2, 4, 6));
            Console.WriteLine(EvenlySpaced(4, 6, 2));
            Console.WriteLine(EvenlySpaced(4, 6, 3));
            Console.ReadLine();
        }

        public static bool EvenlySpaced(int a, int b, int c)
        {
            return a - b == b - c || a - c == b - a || b - c == a - b || a - c == c - b;
        }
    }
}