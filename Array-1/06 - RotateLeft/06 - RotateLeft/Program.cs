using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___RotateLeft
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RotateLeft(new[] { 1, 2, 3 }));
            Console.WriteLine(RotateLeft(new[] { 5, 11, 9 }));
            Console.WriteLine(RotateLeft(new[] { 7, 0, 0 }));
            Console.ReadLine();
        }

        /* Given an array of ints, return an array with the elements "rotated left" so {1, 2, 3} yields {2, 3, 1}. */
        public static int[] RotateLeft(int[] numbers)
        {
            var temp = numbers[0];
            for (var i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }
            numbers[numbers.Length - 1] = temp;
            
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            return numbers;
        }
    }
}
