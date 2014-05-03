using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___SameFirstLast
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SameFirstLast(new[] { 1, 2, 3 }));
            Console.WriteLine(SameFirstLast(new[] { 1, 2, 3, 1 }));
            Console.WriteLine(SameFirstLast(new[] { 1, 2, 1 }));
            Console.ReadLine();
        }

        /* Given an array of ints, return true if the array is length 1 or more, 
         * and the first element and the last element are equal. */

        public static bool SameFirstLast(int[] numbers)
        {
            return numbers.Length >= 1 && numbers[0].Equals(numbers[numbers.Length - 1]);
        }
    }
}
