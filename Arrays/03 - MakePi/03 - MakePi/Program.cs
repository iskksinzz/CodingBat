using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___MakePi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MakePi(3));
            Console.ReadLine();
        }

        /* Return an int array length n containing the first n digits of pi. */

        public static int[] MakePi(int n)
        {
            var pi = Math.PI;
            var str = pi.ToString().Remove(1, 1);
            var numbers = new int[n];

            for (var i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(str[i].ToString());
                Console.Write(numbers[i]);
            }
            return null;
        }
    }
}
