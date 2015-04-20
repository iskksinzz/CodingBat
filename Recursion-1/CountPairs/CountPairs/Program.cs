using System;

namespace CountPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountPairs("axa"));
            Console.WriteLine(CountPairs("axax"));
            Console.WriteLine(CountPairs("axbx"));
            Console.ReadLine();
        }

        private static int CountPairs(string str)
        {
            if (str.Length < 3)
                return 0;
            if (str[0].Equals(str[2]))
                return 1 + CountPairs(str.Substring(1));

            return CountPairs(str.Substring(1));
        }
    }
}
