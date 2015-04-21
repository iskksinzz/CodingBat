using System;

namespace CountAbc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountAbc("abc"));
            Console.WriteLine(CountAbc("abcxxabc"));
            Console.WriteLine(CountAbc("abaxxaba"));
            Console.ReadLine();
        }

        private static int CountAbc(string str)
        {
            if (str.Length < 3)
                return 0;
            if (str.Substring(0, 3).Equals("abc") || str.Substring(0, 3).Equals("aba"))
                return 1 + CountAbc(str.Substring(1));
            return CountAbc(str.Substring(1));
        }
    }
}
