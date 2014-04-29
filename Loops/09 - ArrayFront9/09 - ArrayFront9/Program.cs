using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___ArrayFront9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ArrayFront9(new[] {1,2,9,3,4}));
            Console.WriteLine(ArrayFront9(new[] {1,2,3,4,9}));
            Console.WriteLine(ArrayFront9(new[] {1,2,3,4,5}));
            Console.WriteLine(ArrayFront9(new[] {1,2,3,9}));
            Console.ReadLine();
        }

        /* Given an array of ints, return true if one of the first 4 elements in the array is a 9. The array length may be less than 4. */
        public static bool ArrayFront9(int[] numbers)
        {
            return numbers.Length < 4 ? numbers.Contains(9) : numbers.Take(4).Contains(9);
        }
    }
}
