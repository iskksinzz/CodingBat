using System;

namespace HasOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HasOne(10));
            Console.WriteLine(HasOne(22));
            Console.WriteLine(HasOne(220));
            Console.ReadLine();
        }

        private static bool HasOne(int n)
        {
            return n != 0 && (n % 10 == 1 || HasOne(n / 10));
        }
    }
}
