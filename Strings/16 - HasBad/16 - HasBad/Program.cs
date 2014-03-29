using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16___HasBad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HasBad("badxx"));
            Console.WriteLine(HasBad("xbadxx"));
            Console.WriteLine(HasBad("xxbadxx"));
            Console.WriteLine(HasBad(""));
            Console.WriteLine(HasBad(null));
            Console.WriteLine(HasBad("a"));
            Console.ReadLine();
        }

        /* Given a string, return true if "bad" appears starting at index 0 or 1 in the string, 
         * such as with "badxxx" or "xbadxx" but not "xxbadxx". 
         * The string may be any length, including 0.
         */
        public static bool HasBad(string str)
        {
            if (string.IsNullOrEmpty(str) || str.Length < 2)
            {
                return false;
            }
            else
            {
                return str.Substring(0, 3).Equals("bad") || str.Substring(1, 3).Equals("bad");
            }
        }
    }
}
