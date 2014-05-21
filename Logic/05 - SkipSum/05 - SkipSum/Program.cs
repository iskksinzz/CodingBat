using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___SkipSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SkipSum(3, 4));
            Console.WriteLine(SkipSum(9, 4));
            Console.WriteLine(SkipSum(10, 11));
            Console.ReadLine();
        }

        /* Given 2 ints, a and b, return their sum. 
         * However, sums in the range 10..19 inclusive are forbidden, so in that case just return 20. */
        public static int SkipSum(int a, int b)
        {
            return a + b >= 10 && a + b <= 19 ? 20 : a + b;
        }
    }
}
