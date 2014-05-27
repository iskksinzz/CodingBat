using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___AreInOrder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AreInOrder(1, 2, 4, false));
            Console.WriteLine(AreInOrder(1, 2, 1, false));
            Console.WriteLine(AreInOrder(1, 1, 2, true));
            Console.ReadLine();
        }

        /* Given three ints, a b c, return true if b is greater than a, and c is greater than b.
         * However, with the exception that if "bOk" is true, b does not need to be greater than a. */
        public static bool AreInOrder(int a, int b, int c, bool bOk)
        {
            return (bOk && c > b) || (!bOk && (b > a && c > b));
        }
    }
}
