using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefixAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PrefixAgain("abXYabc", 1));
            Console.WriteLine(PrefixAgain("abXYabc", 2));
            Console.WriteLine(PrefixAgain("abXYabc", 3));
            Console.ReadLine();
        }

        /* Given a string, consider the prefix string made of the first N chars of the string. 
         * Does that prefix string appear somewhere else in the string? 
         * Assume that the string is not empty and that N is in the range 1..str.Length. */
        public static bool PrefixAgain(string str, int n)
        {
            var prefix = str.Substring(0, n);
            for (var i = n; i <= str.Length-n; i++)
            {
                if (str.Substring(i, n).Equals(prefix))
                    return true;
            }
            return false;
        }
    }
}
