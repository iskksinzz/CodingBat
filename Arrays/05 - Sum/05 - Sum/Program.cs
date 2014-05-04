using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(new[] { 1, 2, 3 }));
            Console.WriteLine(Sum(new[] { 5, 11, 2 }));
            Console.WriteLine(Sum(new[] { 7, 0, 0 }));
            Console.ReadLine();
        }

        /* Given an array of ints, return the sum of all the elements. */
        public static int Sum(int[] numbers)
        {
            var sum = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;

            // foreach loop
            //foreach (var number in numbers)
            //{
            //    sum += number;
            //}
            //return sum;

            // LINQ
            //return numbers.Sum();
        }
    }
}
