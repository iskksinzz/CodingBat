using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___InRange
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(InRange(5, false));
            Console.WriteLine(InRange(11, false));
            Console.WriteLine(InRange(11, true));
            Console.ReadLine();
        }

        /* Given a number n, return true if n is in the range 1..10, inclusive. 
         * Unless "outsideMode" is true, in which case return true if the number 
         * is less or equal to 1, or greater or equal to 10. */
        public static bool InRange(int n, bool outsideMode)
        {
            return (!outsideMode && n > 0 && n < 11) || (outsideMode && (n <= 1 || n >= 10));
        }
    }
}
