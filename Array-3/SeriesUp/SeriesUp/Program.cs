using System;

namespace SeriesUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SeriesUp(3));
            Console.WriteLine(SeriesUp(4));
            Console.WriteLine(SeriesUp(2));
            Console.ReadLine();
        }

        private static int[] SeriesUp(int n)
        {
            var arr = new int[n * (n + 1) / 2];
            var c = 0;
            for (var i = 1; i <= n; i++)
            {
                for (var j = 1; j <= i; j++)
                    arr[c++] = j;
            }
            return arr;
        }
    }
}