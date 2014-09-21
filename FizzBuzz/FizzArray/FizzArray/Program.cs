using System;

namespace FizzArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FizzArray(4));
            Console.WriteLine(FizzArray(1));
            Console.WriteLine(FizzArray(10));
            Console.ReadLine();
        }

        public static int[] FizzArray(int n)
        {
            var arr = new int[n];
            for (var i = 0; i < n; i++)
            {
                arr[i] = i;
            }
            return arr;
        }
    }
}
