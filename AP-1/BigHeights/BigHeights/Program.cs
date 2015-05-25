using System;

namespace BigHeights
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BigHeights(new[] { 5, 3, 6, 7, 2 }, 2, 4));
            Console.WriteLine(BigHeights(new[] { 5, 3, 6, 7, 2 }, 0, 1));
            Console.WriteLine(BigHeights(new[] { 5, 3, 6, 7, 2 }, 0, 4));
            Console.ReadLine();
        }

        private static int BigHeights(int[] heights, int start, int end)
        {
            var sum = 0;
            for (var i = start; i < end; i++)
                if (Math.Abs(heights[i] - heights[i + 1]) >= 5)
                    sum++;
            return sum;
        }
    }
}
