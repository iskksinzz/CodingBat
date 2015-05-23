using System;

namespace ScoreUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ScoreUp(new[] { "a", "a", "b", "b" }, new[] { "a", "c", "b", "c" }));
            Console.WriteLine(ScoreUp(new[] { "a", "a", "b", "b" }, new[] { "a", "a", "b", "c" }));
            Console.WriteLine(ScoreUp(new[] { "a", "a", "b", "b" }, new[] { "a", "a", "b", "b" }));
            Console.ReadLine();
        }

        private static int ScoreUp(string[] key, string[] answers)
        {
            var score = 0;
            for (var i = 0; i < answers.Length; i++)
            {
                if (key[i].Equals(answers[i]))
                    score += 4;
                else if (!answers[i].Equals("?"))
                    score -= 1;
            }
            return score;
        }
    }
}
