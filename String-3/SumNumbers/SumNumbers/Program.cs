using System;
using System.Text.RegularExpressions;

namespace SumNumbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(SumNumbers("abc123xyz"));
            Console.WriteLine(SumNumbers("aa11b33"));
            Console.WriteLine(SumNumbers("7 11"));
            Console.WriteLine(SumNumbers("Chocolate"));
            Console.WriteLine(SumNumbers("5hoco1a1e"));
            Console.WriteLine(SumNumbers("5$$1;;1!!"));
            Console.WriteLine(SumNumbers("a1234bb11"));
            Console.WriteLine(SumNumbers(""));
            Console.WriteLine(SumNumbers("a22bbb3"));
            Console.ReadLine();
        }

        public static int SumNumbers(string str)
        {
            var sum = 0;
            foreach (var number in Regex.Split(str, "[^0-9]"))
            {
                int n;
                var isNumeric = int.TryParse(number, out n);
                if (isNumeric)
                    sum += n;
            }
            return sum;
        }
    }
}