using System;

namespace fizzArray2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FizzArray2(4));
            Console.WriteLine(FizzArray2(10));
            Console.WriteLine(FizzArray2(2));
            Console.ReadLine();
        }

        public static string[] FizzArray2(int n)
        {
            var sarr = new string[n];
            for (var i = 0; i < n; i++)
            {
                sarr[i] = Convert.ToString(i);
            }
            return sarr;
        }
    }
}
