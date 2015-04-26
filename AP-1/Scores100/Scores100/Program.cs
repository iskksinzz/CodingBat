using System;

namespace Scores100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Scores100(new[] { 1, 100, 100 }));
            Console.WriteLine(Scores100(new[] { 1, 100, 99, 100 }));
            Console.WriteLine(Scores100(new[] { 100, 1, 100, 100 }));
            Console.ReadLine();
        }

        private static bool Scores100(int[] scores)
        {
            for (var i = 0; i < scores.Length - 1; i++)
                if (scores[i] == 100 && scores[i + 1] == 100)
                    return true;
            return false;
        }
    }
}
