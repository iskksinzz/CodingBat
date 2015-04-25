using System;

namespace StrCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StrCount("catcowcat", "cat"));
            Console.WriteLine(StrCount("catcowcat", "cow"));
            Console.WriteLine(StrCount("catcowcat", "dog"));
            Console.ReadLine();
        }

        private static int StrCount(string str, string sub)
        {
            if (str.Length < sub.Length)
                return 0;
            if (str.Substring(0, sub.Length).Equals(sub))
                return 1 + StrCount(str.Substring(sub.Length), sub);
            return StrCount(str.Substring(1), sub);
        }
    }
}
