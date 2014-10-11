using System;

namespace FizzArray3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FizzArray3(5, 10));
            Console.ReadLine();
        }

        public static int[] FizzArray3(int s, int e)
        {
            var arr = new int[e - s];
            var c = s;
            for (var i = 0; i < e-s; i++)
            {
                arr[i] = c++;
            }
            return arr;
        }
    }
}
