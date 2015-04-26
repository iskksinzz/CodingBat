using System;

namespace ScoresClump
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ScoresClump(new[] { 3, 4, 5 }));
            Console.WriteLine(ScoresClump(new[] { 3, 4, 6 }));
            Console.WriteLine(ScoresClump(new[] { 1, 3, 5, 5 }));
            Console.ReadLine();
        }

        private static bool ScoresClump(int[] scores)
        {
            for (var i = 0; i < scores.Length - 2; i++)
                if (scores[i + 2] - scores[i] < 3)
                    return true;
            return false;
        }
    }
}
