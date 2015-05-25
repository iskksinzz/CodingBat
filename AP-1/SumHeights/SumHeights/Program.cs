using System;

namespace SumHeights
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumHeights(new[] { 5, 3, 6, 7, 2 }, 2, 4));
            Console.WriteLine(SumHeights(new[] { 5, 3, 6, 7, 2 }, 0, 1));
            Console.WriteLine(SumHeights(new[] { 5, 3, 6, 7, 2 }, 0, 4));
            Console.ReadLine();
        }

        private static int SumHeights(int[] heights, int start, int end)
        {
            var sum = 0;
            for (var i = start; i < end; i++)
                sum += Math.Abs(heights[i] - heights[i + 1]);
            return sum;
        }
    }
}
