using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16___NoTriples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NoTriples(new[] { 1, 1, 2, 2, 1 }));
            Console.WriteLine(NoTriples(new[] { 1, 1, 2, 2, 2, 1 }));
            Console.WriteLine(NoTriples(new[] { 1, 1, 1, 2, 2, 2, 1 }));
            Console.ReadLine();
        }

        /* Given an array of ints, we'll say that a triple is a value appearing 3 times in a row in the array. 
         * Return true if the array does not contain any triples. */

        public static bool NoTriples(int[] numbers)
        {
            for (var i = 0; i < numbers.Length - 1; i++)
            {
                 if(numbers[i].Equals(numbers[i + 1]) && numbers[i + 2].Equals(numbers[i]))
                     return false;
            }
            return true;
        }
    }
}
