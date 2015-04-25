using System;

namespace NestParen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NestParen("(())"));
            Console.WriteLine(NestParen("((()))"));
            Console.WriteLine(NestParen("(((x))"));
            Console.ReadLine();
        }

        private static bool NestParen(string str)
        {
            if (str.Length < 1)
                return true;
            if (str[0].Equals('(') && str[str.Length - 1].Equals(')'))
                return NestParen(str.Substring(1, str.Length - 2));
            return false;
        }
    }
}
