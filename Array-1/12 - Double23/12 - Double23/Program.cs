using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___Double23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Double23(new[] { 1, 2, 3 }));
            Console.WriteLine(Double23(new[] { 2, 4, 3, 3 }));
            Console.WriteLine(Double23(new[] { 2, 2, 5, 4 }));
            Console.ReadLine();
        }

        /* Given an int array, return true if the array contains 2 twice, or 3 twice. */
        public static bool Double23(int[] numbers)
        {
            for (var i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == 2 && numbers[i + 1] == 2 || numbers[i] == 3 && numbers[i + 1] == 3)
                    return true;
            }
            return false;
        }
    }
}
