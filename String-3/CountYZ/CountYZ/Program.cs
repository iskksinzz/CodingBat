using System;
using System.Text.RegularExpressions;

namespace CountYZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountYZ("fez day"));
            Console.WriteLine(CountYZ("day fez"));
            Console.WriteLine(CountYZ("day fyyyz"));
            Console.ReadLine();
        }

        public static int CountYZ(string str)
        {
            return Regex.Split(str, "[yzYZ](?!\\p{L})").Length - 1;
        }
    }
}
