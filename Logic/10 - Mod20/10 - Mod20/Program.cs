using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Mod20
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mod20(20));
            Console.WriteLine(Mod20(21));
            Console.WriteLine(Mod20(22));
            Console.ReadLine();
        }

        /* Return true if the given non-negative number is 1 or 2 more than a multiple of 20. */
        public static bool Mod20(int n)
        {
            return (n % 20 == 1) || (n % 20 == 2);
        }
    }
}
