using System;

namespace WordsFront
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WordsFront(new[] { "a", "b", "c", "d" }, 1));
            Console.WriteLine(WordsFront(new[] { "a", "b", "c", "d" }, 2));
            Console.WriteLine(WordsFront(new[] { "a", "b", "c", "d" }, 3));
            Console.ReadLine();
        }

        private static string[] WordsFront(string[] words, int n)
        {
            var arr = new string[n];
            for (var i = 0; i < n; i++)
                arr[i] = words[i];
            return arr;
        }
    }
}
