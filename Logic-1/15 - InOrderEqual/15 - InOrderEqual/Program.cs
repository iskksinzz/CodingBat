using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___InOrderEqual
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(InOrderEqual(2, 5, 11, false));
            Console.WriteLine(InOrderEqual(5, 7, 6, false));
            Console.WriteLine(InOrderEqual(5, 5, 7, true));
            Console.ReadLine();
        }

        /* Given three ints, a b c, return true if they are in strict increasing order, 
         * such as 2 5 11, or 5 6 7, but not 6 5 7 or 5 5 7. 
         * However, with the exception that if "equalOk" is true, equality is allowed, such as 5 5 7 or 5 5 5. */
        public static bool InOrderEqual(int a, int b, int c, bool equalOk)
        {
            return (!equalOk && a < b && b < c) || (equalOk && (a <= b && b <= c));
        }
    }
}
