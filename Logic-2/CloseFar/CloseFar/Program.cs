using System;

namespace CloseFar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CloseFar(1, 2, 10));
            Console.WriteLine(CloseFar(1, 2, 3));
            Console.WriteLine(CloseFar(4, 1, 3));
            Console.ReadLine();
        }

        public static bool CloseFar(int a, int b, int c)
        {
            return Math.Abs(b - c) > 1 && (Math.Abs(a - b) < 2 && Math.Abs(a - c) > 1 || Math.Abs(a - c) < 2 && Math.Abs(a - b) > 1);
        }
    }
}
