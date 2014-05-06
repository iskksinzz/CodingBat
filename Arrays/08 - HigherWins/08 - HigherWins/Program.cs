using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___HigherWins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HigherWins(new[] { 4, 2, 3, 6, 4, 7, 3 }));
            Console.ReadLine();
        }

        /* Given an array of ints, figure out which is larger between the first and last elements in the array, 
         * and set all the other elements to be that value. Return the changed array. */
        public static int[] HigherWins(int[] numbers)
        {
            // foreach-loop with LINQ
            //var highestValue = numbers[0];
            //foreach (var number in numbers.Where(number => number > numbers[0]))
            //{
            //    highestValue = number;
            //}

            // foreach-loop
            //var highestValue = numbers[0];
            //foreach (var number in numbers)
            //{
            //    if (number > numbers[0])
            //        highestValue = number;
            //}

            // for-loop
            var highestValue = numbers[0];
            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[0])
                    highestValue = numbers[i];
            }

            // Returns the changed array
            for (var i = 0; i < numbers.Length; i++)
            {
                numbers[i] = highestValue;
            }
            return numbers;
        }
    }
}