using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___Make2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Make2(new[] { 4, 5 }, new[] { 1, 2, 3 }));
            Console.WriteLine(Make2(new[] { 4 }, new[] { 1, 2, 3 }));
            Console.WriteLine(Make2(new int[0], new[] { 1, 2 }));
            Console.ReadLine();
        }

        /* Given 2 int arrays, a and b, return a new array length 2 containing, as much as will fit, 
         * the elements from a followed by the elements from b. The arrays may be any length, including 0, 
         * but there will be 2 or more elements available between the 2 arrays. */
        public static int[] Make2(int[] a, int[] b)
        {
            var arr = new int[2];
            var i = 0;

            while (i < a.Length && i < arr.Length)
            {
                arr[i] = a[i];
                i++;
            }
            while ((i - a.Length) < b.Length && i < arr.Length)
            {
                arr[i] = b[i - a.Length];
                i++;
            }
            return arr;
        }
    }
}
