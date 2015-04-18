using System;

namespace EndX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EndX("xxre"));
            Console.WriteLine(EndX("xxhixx"));
            Console.WriteLine(EndX("xhixhix"));
            Console.ReadLine();
        }

        private static string EndX(string str)
        {
            if (str.Length < 2)
                return str;
            if (str[0].Equals('x'))
                return EndX(str.Substring(1)) + str[0];
            return str[0] + EndX(str.Substring(1));
        }
    }
}
