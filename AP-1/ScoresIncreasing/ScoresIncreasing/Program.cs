using System;

namespace ScoresIncreasing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ScoresIncreasing(new[] { 1, 3, 4 }));
            Console.WriteLine(ScoresIncreasing(new[] { 1, 3, 2 }));
            Console.WriteLine(ScoresIncreasing(new[] { 1, 1, 4 }));
            Console.ReadLine();
        }

        private static bool ScoresIncreasing(int[] scores)
        {
            for (var i = 0; i < scores.Length - 1; i++)
                if (scores[i] > scores[i + 1])
                    return false;
            return true;
        }
    }
}
