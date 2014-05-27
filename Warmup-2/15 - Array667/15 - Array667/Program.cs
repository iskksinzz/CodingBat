using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___Array667
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Array667(new[] { 6, 6, 2 }));
            Console.WriteLine(Array667(new[] { 6, 6, 2, 6 }));
            Console.WriteLine(Array667(new[] { 6, 7, 2, 6 }));
            Console.ReadLine();
        }

        /* Given an array of ints, return the number of times that two 6's are next to each other in the array. 
         * Also count instances where the second "6" is actually a 7. */

        public static int Array667(int[] numbers)
        {
            var count = 0;
            for (var i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i].Equals(6) && (numbers[i + 1].Equals(6) || numbers[i + 1].Equals(7))) count++;
            }
            return count;
        }
    }
}
