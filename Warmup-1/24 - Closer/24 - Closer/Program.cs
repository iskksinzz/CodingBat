using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24___Closer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Closer(8, 13));
            Console.WriteLine(Closer(13, 8));
            Console.WriteLine(Closer(13, 7));
            Console.ReadLine();
        }

        /* Given 2 int values, return whichever value is nearest to the value 10, 
         * or return 0 in the event of a tie. */
        public static int Closer(int a, int b)
        {
            const int n = 10;
            var val = Math.Abs(a - n);
            var val2 = Math.Abs(b - n);

            return val == val2 ? 0 : (val < val2 ? a : b);
        }
    }
}
