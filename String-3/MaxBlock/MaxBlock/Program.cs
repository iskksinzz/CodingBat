using System;
using System.Text.RegularExpressions;

namespace MaxBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxBlock("hoopla"));
            Console.WriteLine(MaxBlock("abbCCCddBBBxx"));
            Console.WriteLine(MaxBlock(""));
            Console.ReadLine();
        }

        private static int MaxBlock(string str)
        {
            var matches = Regex.Matches(str, @"(.)\1+");
            var max = 0;

            foreach (Match match in matches)
                if (match.Length > max) max = match.Length;

            return max;
        }
    }
}
