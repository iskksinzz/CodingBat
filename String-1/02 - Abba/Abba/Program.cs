using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abba
{
    class Program
    {
        static void Main(string[] args)
        {
            Abba("Hello", "World");
            Console.ReadLine();
        }

        /* Given two strings, a and b, return the result of putting them together in the order abba, 
         * e.g. "Hi" and "Bye" returns "HiByeByeHi". 
         */
        public static void Abba(string a, string b)
        {
            Console.WriteLine(a+b + b+a);
        }
    }
}
