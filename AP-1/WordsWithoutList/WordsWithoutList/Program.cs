using System;
using System.Collections.Generic;

namespace WordsWithoutList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WordsWithoutList(new[] { "a", "bb", "b", "ccc" }, 1));
            Console.WriteLine(WordsWithoutList(new[] { "a", "bb", "b", "ccc" }, 3));
            Console.WriteLine(WordsWithoutList(new[] { "a", "bb", "b", "ccc" }, 4));
            Console.ReadLine();
        }

        private static List<string> WordsWithoutList(string[] words, int len)
        {
            var list = new List<string>();
            foreach (var word in words)
                if (word.Length != len)
                    list.Add(word);
            return list;
        }
    }
}
