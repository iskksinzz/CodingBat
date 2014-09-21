using System;

namespace FizzString2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FizzString2(1));
            Console.WriteLine(FizzString2(2));
            Console.WriteLine(FizzString2(3));
            Console.ReadLine();
        }

        public static string FizzString2(int n)
        {
            if (n % 3 == 0 && n % 5 == 0)
                return "FizzBuzz!";

            if (n % 3 == 0)
                return "Fizz!";

            if (n % 5 == 0)
                return "Buzz!";

            return n + "!";
        }
    }
}
