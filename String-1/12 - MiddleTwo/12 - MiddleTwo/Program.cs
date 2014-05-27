using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___MiddleTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MiddleTwo("string"));
            Console.WriteLine(MiddleTwo("code"));
            Console.WriteLine(MiddleTwo("Practice"));
            Console.ReadLine();
        }

        /* Given a string of even length, return a string made of the middle two chars, 
         * so the string "string" yields "ri". The string length will be at least 2. 
         */
        public static string MiddleTwo(string str)
        {
            return str.Substring(((str.Length / 2) - 1), 2);
        }
    }
}
