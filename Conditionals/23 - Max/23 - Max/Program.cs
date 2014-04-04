using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23___Max
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Max(1,2,3));
            Console.WriteLine(Max(1,3,2));
            Console.WriteLine(Max(3,2,1));
            Console.ReadLine();
        }

        /* Given three int values, a b c, return the largest. */
        public static int Max(int a, int b, int c)
        {
            var max = Math.Max(a, Math.Max(b, c));
            return max;
        }
    }
}
