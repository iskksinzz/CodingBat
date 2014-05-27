using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16___LastDigit
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LastDigit(23, 19, 13));
            Console.WriteLine(LastDigit(23, 19, 12));
            Console.WriteLine(LastDigit(23, 19, 3));
            Console.ReadLine();
        }

        /* Given three ints, a b c, return true if two or more of them 
         * have the same rightmost digit. The ints are non-negative. */
        public static bool LastDigit(int a, int b, int c)
        {
            return (a % 10 == b % 10) || (b % 10 == c % 10) || (a % 10 == c % 10);
        }
    }
}
