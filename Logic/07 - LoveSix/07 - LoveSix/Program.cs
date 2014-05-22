using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___LoveSix
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LoveSix(6, 4));
            Console.WriteLine(LoveSix(4, 5));
            Console.WriteLine(LoveSix(1, 5));
            Console.ReadLine();
        }

        /* The number 6 is a truly great number. 
         * Given two int values, a and b, return true if either one is 6. 
         * Or if their sum or difference is 6. */
        public static bool LoveSix(int a, int b)
        {
            return a == 6 || b == 6 || a + b == 6 || Math.Abs(a - b) == 6;
        }
    }
}
