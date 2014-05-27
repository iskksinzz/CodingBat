using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___AtFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AtFirst("hello"));
            Console.WriteLine(AtFirst("hi"));
            Console.WriteLine(AtFirst("h"));
            Console.ReadKey();
        }

        /* Given a string, return a string length 2 made of its first 2 chars. 
         * If the string length is less than 2, use '@' for the missing chars. 
         */
        public static string AtFirst(string str)
        {
            return str.Length < 2 ? str + "@" : str.Substring(0, 2);
        }
    }
}
