using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___MissingChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MissingChar("kitten", 1));
            Console.WriteLine(MissingChar("kitten", 0));
            Console.WriteLine(MissingChar("kitten", 4));
            
            Console.ReadLine();
        }

        /* Given a non-empty string and an int n, return a new string where the char at index n has been removed.
         * The value of n will be a valid index of a char in the original string (Don't check for bad index).  */

        public static string MissingChar(string str, int n)
        {
            return str.Remove(n, 1);
        }
    }
}
