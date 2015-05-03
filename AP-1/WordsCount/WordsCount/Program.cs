using System;
using System.Linq;

namespace WordsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WordsCount(new[] { "a", "bb", "b", "ccc" }, 1));
            Console.WriteLine(WordsCount(new[] { "a", "bb", "b", "ccc" }, 3));
            Console.WriteLine(WordsCount(new[] { "a", "bb", "b", "ccc" }, 4));
            Console.ReadLine();
        }

        private static int WordsCount(string[] words, int len)
        {
            return words.Count(word => word.Length == len);
        }
    }
}
