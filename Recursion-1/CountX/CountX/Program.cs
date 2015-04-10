using System;

namespace CountX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountX("xxhixx"));
            Console.WriteLine(CountX("xhixhix"));
            Console.WriteLine(CountX("hi"));
            Console.ReadLine();
        }

        private static int CountX(string str)
        {
            return str.Length == 0 ? 0 : str[0] == 'x' ? 1 + CountX(str.Substring(1)) : CountX(str.Substring(1));
        }
    }
}
