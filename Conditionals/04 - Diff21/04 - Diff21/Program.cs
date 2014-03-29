using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Diff21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Diff21(23));
            Console.WriteLine(Diff21(10));
            Console.WriteLine(Diff21(21));
            Console.ReadLine();
        }

        /* Given an int n, return the absolute value of the difference between n and 21,
         * except return double the absolute value of the difference if n is over 21. */

        public static int Diff21(int n)
        {
            const int x = 21;

            if (n > x)
            {
                return (n - x)*2;
            }
            return x - n;
        }
    }
}
