using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___Pattern51
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Pattern51(new[] { 1, 2, 7, 1 }));
            Console.WriteLine(Pattern51(new[] { 1, 2, 8, 1 }));
            Console.WriteLine(Pattern51(new[] { 2, 7, 1 }));
            Console.ReadLine();
        }

        /* Given an array of ints, return true if it contains a 2, 7, 1 pattern -- a value, followed by the value plus 5, followed by the value minus 1. 
         * Additionally the 271 counts even if the "1" differs by 2 or less from the correct value. */

        public static bool Pattern51(int[] numbers)
        {
            for (var i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i + 1].Equals(numbers[i] + 5) && Math.Abs(numbers[i + 2] - (numbers[i] - 1)) <= 2) 
                    return true;
            }
            return false;
        }
    }
}
