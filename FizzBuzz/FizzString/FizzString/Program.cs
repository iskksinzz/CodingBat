using System;

namespace FizzString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FizzString("fig"));
            Console.WriteLine(FizzString("dib"));
            Console.WriteLine(FizzString("fib"));
            Console.ReadLine();
        }

        public static string FizzString(string str)
        {
            if (str.StartsWith("f") && str.EndsWith("b"))
                return "FizzBuzz";
            if (str.StartsWith("f"))
                return "Fizz";
            if (str.EndsWith("b"))
                return "Buzz";

            return str;
        }
    }
}
