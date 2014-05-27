using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Array123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Array12(new[] {1,1,2,3,1}));
            Console.WriteLine(Array12(new[] {1,1,2,4,1}));
            Console.WriteLine(Array12(new[] {1,1,2,1,2,3}));
            Console.ReadLine();
        }

        /* Given an array of ints, return true if .. 1, 2, 3, .. appears in the array somewhere. */
        public static bool Array12(int[] numbers)
        {
            for (var i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] == 1 && numbers[i + 1] == 2 && numbers[i + 2] == 3)
                    return true;
            }
            return false;
        }
    }
}
