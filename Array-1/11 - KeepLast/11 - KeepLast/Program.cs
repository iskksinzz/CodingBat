using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___KeepLast
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(KeepLast(new[] { 4, 5, 6 }));
            Console.WriteLine(KeepLast(new[] { 1, 2 }));
            Console.WriteLine(KeepLast(new[] { 3 }));
            Console.ReadLine();
        }

        /* Given an int array, return a new array with double the length where its last 
         * element is the same as the original array, and all the other elements are 0. 
         * The original array will be length 1 or more. 
         * Note: by default, a new int array contains all 0's. */
        public static int[] KeepLast(int[] numbers)
        {
            var arr = new int[numbers.Length * 2];
            arr[arr.Length - 1] = numbers[numbers.Length - 1];

            return arr;
        }
    }
}
