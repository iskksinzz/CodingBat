using System;

namespace AllStar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AllStar("hello"));
            Console.WriteLine(AllStar("abc"));
            Console.WriteLine(AllStar("ab"));
            Console.ReadLine();
        }

        private static string AllStar(string str)
        {
            if (str.Length <= 1)
                return str;
            return str[0] + "*" + AllStar(str.Substring(1));
        }
    }
}
