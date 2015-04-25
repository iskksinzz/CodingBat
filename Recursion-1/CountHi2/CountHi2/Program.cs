using System;

namespace CountHi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountHi2("ahixhi"));
            Console.WriteLine(CountHi2("ahibhi"));
            Console.WriteLine(CountHi2("xhixhi"));
            Console.ReadLine();
        }

        private static int CountHi2(string str)
        {
            if (str.Length < 2)
                return 0;
            if (str[0].Equals('x'))
                return str[1] != 'x' ? CountHi2(str.Substring(2)) : CountHi2(str.Substring(1));
            if (str.Substring(0, 2).Equals("hi"))
                return 1 + CountHi2(str.Substring(2));
            return CountHi2(str.Substring(1));
        }
    }
}
