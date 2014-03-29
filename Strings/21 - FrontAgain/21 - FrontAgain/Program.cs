using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21___FrontAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FrontAgain("edited"));
            Console.WriteLine(FrontAgain("edit"));
            Console.WriteLine(FrontAgain("ed"));
            Console.ReadKey();
        }

        /* Given a string, return true if the first 2 chars in the string
         * also appear at the end of the string, such as with "edited". 
         */
        public static bool FrontAgain(string str)
        {
            return str.Substring(0, 2).Equals(str.Substring(str.Length - 2));
        } 
    }
}
