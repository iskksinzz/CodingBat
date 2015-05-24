using System;

namespace ScoresSpecial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ScoresSpecial(new[] { 12, 10, 4 }, new[] { 2, 20, 30 }));
            Console.WriteLine(ScoresSpecial(new[] { 20, 10, 4 }, new[] { 2, 20, 10 }));
            Console.WriteLine(ScoresSpecial(new[] { 12, 11, 4 }, new[] { 2, 20, 31 }));
            Console.ReadLine();
        }

        private static int ScoresSpecial(int[] a, int[] b)
        {
            return LargestSpecialScore(a) + LargestSpecialScore(b);
        }

        private static int LargestSpecialScore(int[] array)
        {
            var score = 0;
            foreach (var num in array)
            {
                if (num % 10 == 0 && num > score)
                    score = num;
            }
            return score;
        }
    }
}
