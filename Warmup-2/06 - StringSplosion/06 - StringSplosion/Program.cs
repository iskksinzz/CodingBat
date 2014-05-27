using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___StringSplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringSplosion("Code"));
            Console.WriteLine(StringSplosion("abc"));
            Console.WriteLine(StringSplosion("ab"));
            Console.ReadLine();
        }

        /* Given a non-empty string like "Code" return a string like "CCoCodCode".  (first char, first two, first 3, etc) */
        public static string StringSplosion(string str)
        {
            var result = string.Empty;
            for (var i = 0; i < str.Length; i++)
            {
                result += str.Substring(0, i + 1);
            }
            return result;
        }
    }
}
