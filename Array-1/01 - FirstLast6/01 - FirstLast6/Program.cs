using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___FirstLast6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstLast6(new[] { 1, 2, 6 }));
            Console.WriteLine(FirstLast6(new[] { 6, 1, 2, 3 }));
            Console.WriteLine(FirstLast6(new[] { 13, 6, 1, 2, 3 }));
            Console.ReadLine();
        }

        /* Given an array of ints, return true if 6 appears as either the first or last element in the array. 
         * The array will be length 1 or more. */
        public static bool FirstLast6(int[] numbers)
        {
            return numbers[0] == 6 || numbers[numbers.Length - 1] == 6;
        }
    }
}
