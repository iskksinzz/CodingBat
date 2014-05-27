using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___HasEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HasEven(new[] { 2, 5 }));
            Console.WriteLine(HasEven(new[] { 4, 3 }));
            Console.WriteLine(HasEven(new[] { 7, 5 }));
            Console.ReadLine();
        }

        /* Given an int array , return true if it contains an even number (HINT: Use Mod (%)). */
        public static bool HasEven(int[] numbers)
        {
            foreach (var number in numbers)
            {
                if (number % 2 == 0) return true;
            }
            return false;

            // LINQ
            //return numbers.Any(number => number % 2 == 0);
        }
    }
}
