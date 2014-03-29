using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___TrimOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TrimOne("Hello"));
            Console.WriteLine(TrimOne("World"));
            Console.ReadLine();
        }

        /* Given a string, return a version without the first and last char, so "Hello" yields "ell". 
         * The string length will be at least 2. 
         */
        public static string TrimOne(string str)
        {
            return str.Substring(1, str.Length - 2);
        }
    }
}
