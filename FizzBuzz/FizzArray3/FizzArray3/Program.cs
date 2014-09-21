using System;

namespace FizzArray3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FizzArray3(5, 10));
            Console.WriteLine(FizzArray3(11, 18));
            Console.WriteLine(FizzArray3(1, 3));
            Console.ReadLine();
        }

        public static int[] FizzArray3(int start, int end)
        {
            var arr = new int[end - start];
            var j = 0;
            for (int i = start; i < end; i++)
            {
                arr[j++] = i;
            }
            return arr;
        }
    }
}
