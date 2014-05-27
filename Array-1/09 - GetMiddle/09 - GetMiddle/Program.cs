using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___GetMiddle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMiddle(new[] { 1, 2, 3 }, new[] { 4, 5, 6 }));
            Console.ReadLine();
        }

        /* Given 2 int arrays, a and b, each length 3, return a new array length 2 containing their middle elements. */
        public static int[] GetMiddle(int[] a, int[] b)
        {
            return new[] { a[1], b[1] };
        }
    }
}
