using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___Mod35
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mod35(3));
            Console.WriteLine(Mod35(10));
            Console.WriteLine(Mod35(15));
            Console.ReadLine();
        }

        /* Return true if the given non-negative number is a multiple of 3 or 5, but not both. */
        public static bool Mod35(int n)
        {
            return !(n % 3 == 0 && n % 5 == 0) && ((n % 3 == 0) || (n % 5 == 0));
        }
    }
}
