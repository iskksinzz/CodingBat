using System;
using System.Linq;

namespace WordsWithout
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WordsWithout(new[] { "a", "b", "c", "a" }, "a"));
            Console.WriteLine(WordsWithout(new[] { "a", "b", "c", "a" }, "b"));
            Console.WriteLine(WordsWithout(new[] { "a", "b", "c", "a" }, "c"));
            Console.ReadLine();
        }

        private static string[] WordsWithout(string[] words, string target)
        {

            var arr = new string[words.Count(str => !str.Equals(target))];
            var j = 0;
            foreach (var str in words.Where(str => !str.Equals(target)))
                arr[j++] = str;
            return arr;
        }
    }
}
