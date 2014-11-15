using System;
using System.Text.RegularExpressions;

namespace GHappy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GHappy("xxggxx"));
            Console.WriteLine(GHappy("xxgxx"));
            Console.WriteLine(GHappy("xxggyygxx"));
            Console.ReadLine();
        }

        public static bool GHappy(string str)
        {
            return !Regex.Replace(str, // The string to search for a match.
                                "gg+", // The regular expression pattern to match.
                                "").   // The replacement string.
                                Contains("g"); // If str contains any g's then they're unhappy :(   
        }
    }
}
