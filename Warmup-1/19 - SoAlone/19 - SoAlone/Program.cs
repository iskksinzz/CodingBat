using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19___SoAlone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SoAlone(13, 99));
            Console.WriteLine(SoAlone(21, 19));
            Console.WriteLine(SoAlone(13, 13));
            Console.ReadLine();
        }

        /* We'll say that a number is "teen" if it is in the range 13..19 inclusive. 
         * Given 2 int values, return true if one or the other is teen, but not both. */
        public static bool SoAlone(int a, int b)
        {
            return (a <= 12 || a >= 20) || (b <= 12 || b >= 20);
        }
    }
}
