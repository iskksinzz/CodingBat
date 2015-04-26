using System;

namespace ScoresAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ScoresAverage(new[] { 2, 2, 4, 4 }));
            Console.WriteLine(ScoresAverage(new[] { 4, 4, 4, 2, 2, 2 }));
            Console.WriteLine(ScoresAverage(new[] { 3, 4, 5, 1, 2, 3 }));
            Console.ReadLine();
        }

        private static int ScoresAverage(int[] scores)
        {
            var firstHalf = Average(scores, 0, scores.Length / 2);
            var secondHalf = Average(scores, scores.Length / 2, scores.Length);
            return firstHalf > secondHalf ? firstHalf : secondHalf;
        }

        private static int Average(int[] scores, int start, int end)
        {
            var sum = 0;
            for (var i = start; i < end; i++)
                sum += scores[i];
            return sum / (scores.Length / 2);
        }
    }
}
