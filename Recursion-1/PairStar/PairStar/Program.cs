using System;

namespace PairStar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PairStar("hello"));
            Console.WriteLine(PairStar("xxyy"));
            Console.WriteLine(PairStar("aaaa"));
            Console.ReadLine();
        }

        private static string PairStar(string str)
        {
            if (str.Length < 2)
                return str;
            if (str[0].Equals(str[1]))
                return str[0] + "*" + PairStar(str.Substring(1));
            return str[0] + PairStar(str.Substring(1));
        }
    }
}
