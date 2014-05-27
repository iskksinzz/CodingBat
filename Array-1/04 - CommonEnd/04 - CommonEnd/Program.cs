using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___CommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CommonEnd(new[] { 1, 2, 3 }, new[] { 7, 3 }));
            Console.WriteLine(CommonEnd(new[] { 1, 2, 3 }, new[] { 7, 3, 2 }));
            Console.WriteLine(CommonEnd(new[] { 1, 2, 3 }, new[] { 1, 3 }));
            Console.ReadLine();
        }

        /* Given 2 arrays of ints, a and b, return true if they have the same first element
         * or they have the same last element. Both arrays will be length 1 or more. */
        public static bool CommonEnd(int[] a, int[] b)
        {
            return a[0].Equals(b[0]) || a[a.Length - 1].Equals(b[b.Length - 1]);
        }
    }
}
