using System;
using System.Text.RegularExpressions;

namespace EqualIsNot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EqualIsNot("This is not"));
            Console.WriteLine(EqualIsNot("This is notnot"));
            Console.WriteLine(EqualIsNot("noisxxnotyynotxisi"));
            Console.ReadLine();
        }

        private static bool EqualIsNot(string str)
        {
            return Regex.Matches(str, "is").Count == Regex.Matches(str, "not").Count;
        }
    }
}
