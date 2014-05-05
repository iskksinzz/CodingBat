using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse(new[] { 1, 2, 3 }));
            Console.WriteLine(Reverse(new[] { 5, 11, 9 }));
            Console.WriteLine(Reverse(new[] { 7, 0, 0 }));
            Console.ReadLine();
        }

        /* Given an array of ints length 3, return a new array with the elements 
         * in reverse order, so for example {1, 2, 3} becomes {3, 2, 1}. */
        public static int[] Reverse(int[] numbers)
        {
            for (var i = 0; i < (numbers.Length / 2); i++)
            {
                var temp = numbers[i];
                numbers[i] = numbers[numbers.Length - i - 1];
                numbers[numbers.Length - i - 1] = temp;
            }
            return numbers;

            // Alternative
            //var arr = numbers.Reverse();
            //return arr.ToArray();
        }
    }
}