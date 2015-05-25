using System;

namespace SumHeights2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumHeights2(new[] { 5, 3, 6, 7, 2 }, 2, 4)); //7
            Console.WriteLine(SumHeights2(new[] { 5, 3, 6, 7, 2 }, 0, 1));
            Console.WriteLine(SumHeights2(new[] { 5, 3, 6, 7, 2 }, 0, 4)); //15
            Console.ReadLine();
        }

        private static int SumHeights2(int[] heights, int start, int end)
        {
            var sum = 0;
            for (var i = start; i < end; i++)
            {
                if (heights[i + 1] > heights[i])
                    sum += 2 * Math.Abs(heights[i] - heights[i + 1]);
                else
                    sum += Math.Abs(heights[i] - heights[i + 1]);
            }
            return sum;
        }
    }
}
