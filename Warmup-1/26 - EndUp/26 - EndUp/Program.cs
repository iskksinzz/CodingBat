using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26___EndUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EndUp("Hello"));
            Console.WriteLine(EndUp("hi there"));
            Console.WriteLine(EndUp("hi"));
            Console.ReadLine();
        }

        /* Given a string, return a new string where the last 3 chars are now in upper case. 
         * If the string has less than 3 chars, uppercase whatever is there. */
        public static string EndUp(string str)
        {
            if (str.Length < 3) return str.ToUpper();

            return str.Substring(0, str.Length -3) + str.Substring(str.Length - 3).ToUpper();
        }
    }
}
