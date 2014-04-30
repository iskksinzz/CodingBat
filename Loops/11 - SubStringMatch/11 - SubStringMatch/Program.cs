using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___SubStringMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SubStringMatch("xxcaazz", "xxbaaz"));
            Console.WriteLine(SubStringMatch("abc", "abc"));
            Console.WriteLine(SubStringMatch("abc", "axc"));
            Console.ReadLine();
        }

        /* Given 2 strings, a and b, return the number of the positions where they contain the same length 2 substring. 
         * So "xxcaazz" and "xxbaaz" yields 3, since the "xx", "aa", and 
         * "az" substrings appear in the same place in both strings. */

        public static int SubStringMatch(string a, string b)
        {
            var count = 0;
            for (var i = 0; i < a.Length-1; i++)
            {
                var firstString = a.Substring(i, 2);
                for (var j = 0; j < b.Length-1; j++)
                {
                    var secondString = b.Substring(j, 2);
                    if (firstString.Equals(secondString)) count++;
                }
            }
            return count;
        }
    }
}
