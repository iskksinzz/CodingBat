using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___Count9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Count9(new[] {1,2,9}));
            Console.WriteLine(Count9(new[] {1,9,9}));
            Console.WriteLine(Count9(new[] {1,9,9,3,9}));
            Console.ReadLine();
        }

        /* Given an array of ints, return the number of 9's in the array. */
        public static int Count9(int[] numbers)
        {
            return numbers.Count(number => number == 9);
        }
    }
}
