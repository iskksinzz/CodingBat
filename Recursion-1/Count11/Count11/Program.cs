using System;

namespace Count11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Count11("11abc11"));
            Console.WriteLine(Count11("abc11x11x11"));
            Console.WriteLine(Count11("111"));
            Console.ReadLine();
        }

        private static int Count11(string str)
        {
            if (str.Length < 2)
                return 0;
            if (str.Substring(0, 2).Equals("11"))
                return 1 + Count11(str.Substring(2));
            return Count11(str.Substring(1));
        }
    }
}
