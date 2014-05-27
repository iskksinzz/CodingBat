using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___PosNeg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PosNeg(1, -1, false));
            Console.WriteLine(PosNeg(-1, 1, false));
            Console.WriteLine(PosNeg(-4, -5, true));

            Console.ReadLine();
        }

        /* Given two int values, return true if one is negative and one is positive.
         * Except if the parameter "negative" is true, then return true only if both are negative. */

        public static bool PosNeg(int a, int b, bool negative)
        {
            if(negative && (a < 0 && b < 0 ))
                return true;

            return (a < 0 && b > 0) || (a > 0 && b < 0);
        }
    }
}
