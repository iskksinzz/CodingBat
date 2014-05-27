using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___NearHundred
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NearHundred(103));
            Console.WriteLine(NearHundred(90));
            Console.WriteLine(NearHundred(89));

            Console.ReadLine();
        }

        /* Given an int n, return true if it is within 10 of 100 or 200.
           Hint: Check out the C# Math class for absolute value */
        public static bool NearHundred(int n)
        {
            if(Math.Abs(n - 100) <= 10 || Math.Abs(n - 200) <= 10)
                return true;
            return false;
        }
    }
}
