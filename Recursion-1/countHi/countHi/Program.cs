using System;

namespace countHi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountHi("xxhixx"));
            Console.WriteLine(CountHi("xhixhix"));
            Console.WriteLine(CountHi("hi"));
            Console.ReadLine();
        }

        private static int CountHi(String str)
        {
            if (str.Length <= 1)
                return 0;

            return str.Substring(0, 2).Equals("hi") ? 1 + CountHi(str.Substring(1)) : CountHi(str.Substring(1));
        }
    }
}
