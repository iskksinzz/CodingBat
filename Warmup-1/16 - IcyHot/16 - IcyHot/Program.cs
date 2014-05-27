using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16___IcyHot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IcyHot(120, -1));
            Console.WriteLine(IcyHot(-1, 120));
            Console.WriteLine(IcyHot(2, 120));
            Console.ReadLine();
        }

        /* Given two temperatures, return true if one is less than 0 and the other is greater than 100. */
        public static bool IcyHot(int temp1, int temp2)
        {
            return temp1 < 0 && temp2 > 100 || temp2 < 0 && temp1 > 100;
        }
    }
}
