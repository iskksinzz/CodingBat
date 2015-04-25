using System;

namespace ParenBit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ParenBit("xyz(abc)123"));
            Console.WriteLine(ParenBit("x(hello)"));
            Console.WriteLine(ParenBit("(xy)1"));
            Console.ReadLine();
        }

        private static string ParenBit(string str)
        {
            return str[0] == '(' ? str.Substring(0, str.IndexOf(')') + 1) : ParenBit(str.Substring(1));
        }
    }
}
