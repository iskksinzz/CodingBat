using System;

namespace NoX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NoX("xaxb"));
            Console.WriteLine(NoX("abc"));
            Console.WriteLine(NoX("xx"));
            Console.ReadLine();
        }

        private static string NoX(string str)
        {
            return str.Length < 1
                ? ""
                : str[0].Equals('x') ? "" + NoX(str.Substring(1)) : str[0] + NoX(str.Substring(1));
        }
    }
}
