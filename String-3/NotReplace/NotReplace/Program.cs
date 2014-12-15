using System;
using System.Text.RegularExpressions;

namespace NotReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NotReplace("is test"));
            Console.WriteLine(NotReplace("is-is"));
            Console.WriteLine(NotReplace("This is right"));
            Console.ReadLine();
        }

        private static string NotReplace(string str)
        {
            return Regex.Replace(str, "\\w*(?<![A-Za-z])is\\b", "is not");
        }
    }
}
