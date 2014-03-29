using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___FrontAndBack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FrontAndBack("Hello", 2));
            Console.WriteLine(FrontAndBack("Chocolate", 3));
            Console.WriteLine(FrontAndBack("Chocolate", 1));
            Console.ReadLine();
        }

        /* Given a string and an int n, return a string made of the first and last n chars from the string. 
         * The string length will be at least n. 
         */

        public static string FrontAndBack(string str, int n)
        {
            return str.Substring(0, n) + str.Substring(str.Length -n);
        }
    }
}
