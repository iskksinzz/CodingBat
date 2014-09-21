using System;

namespace FizzArray2
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
            var arr = new string[n];
            for (var i = 0; i < n; i++)
            {
                arr[i] = Convert.ToString(i);
            }
            return arr;
        }
    }
}
