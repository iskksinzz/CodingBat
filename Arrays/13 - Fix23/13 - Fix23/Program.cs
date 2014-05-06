using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___Fix23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fix23(new[] { 1, 2, 3 }));
            Console.WriteLine(Fix23(new[] { 2, 3, 5 }));
            Console.WriteLine(Fix23(new[] { 1, 2, 1 }));
            Console.ReadLine();
        }

        /* Given an int array length 3, if there is a 2 in the array immediately followed by a 3, set the 3 element to 0. 
         * Return the changed array. */
        public static int[] Fix23(int[] numbers)
        {
            for (var i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i].Equals(2) && numbers[i + 1].Equals(3))
                    numbers[i + 1] = 0;
            }
            return numbers;
        }
    }
}
