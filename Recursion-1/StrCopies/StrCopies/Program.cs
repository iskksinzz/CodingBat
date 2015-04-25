using System;

namespace StrCopies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StrCopies("catcowcat", "cat", 2));
            Console.WriteLine(StrCopies("catcowcat", "cow", 2));
            Console.WriteLine(StrCopies("catcowcat", "cow", 1));
            Console.ReadLine();
        }

        private static bool StrCopies(string str, string sub, int n)
        {
            if (str.Length < sub.Length)
                return n <= 0;
            if (str.Substring(0, sub.Length).Equals(sub))
                return StrCopies(str.Substring(1), sub, n - 1);
            return StrCopies(str.Substring(1), sub, n);
        }
    }
}
