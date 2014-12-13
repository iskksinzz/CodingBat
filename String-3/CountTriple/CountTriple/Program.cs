using System;

namespace CountTriple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountTriple("abcXXXabc"));
            Console.WriteLine(CountTriple("xxxabyyyycd"));
            Console.WriteLine(CountTriple("a"));
            Console.ReadLine();
        }

        private static int CountTriple(string str)
        {
            var c = 0;
            for (var i = 0; i < str.Length - 2; i++)
                if (str[i].Equals(str[i + 1]) && str[i].Equals(str[i + 2]))
                    c++;
            return c;
        }
    }
}
