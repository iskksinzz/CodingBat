using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___SpecialEleven
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SpecialEleven(22));
            Console.WriteLine(SpecialEleven(23));
            Console.WriteLine(SpecialEleven(24));
            Console.ReadLine();
        }

        /* We'll say a number is special if it is a multiple of 11 or if it is one more than a multiple of 11. 
         * Return true if the given non-negative number is special. Use the % "mod" operator. */
        public static bool SpecialEleven(int n)
        {
            return (n % 11 == 0) || (n % 11 == 1);
        }
    }
}
