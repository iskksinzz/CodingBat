using System;
using System.Linq;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumDigits("aa1bc2d3"));
            Console.WriteLine(SumDigits("aa11b33"));
            Console.WriteLine(SumDigits("Chocolate"));
            Console.ReadLine();
        }

        private static int SumDigits(string str)
        {
            return str.Where(char.IsDigit).Sum(t => int.Parse(t.ToString()));
        }
    }
}
