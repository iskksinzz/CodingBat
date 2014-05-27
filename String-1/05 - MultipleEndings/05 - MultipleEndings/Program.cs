using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___MultipleEndings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MultipleEndings("Hello"));
            Console.WriteLine(MultipleEndings("Baha"));
            Console.ReadLine();
        }

        /* Given a string, return a new string made of 3 copies of the last 2 chars of the original string. 
         * The string length will be at least 2. 
         */
        public static string MultipleEndings(string str)
        {
            var s = str.Substring(str.Length - 2);
            return s + s + s;
        }
    }
}
