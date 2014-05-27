using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DoubleChar("The"));
            Console.WriteLine(DoubleChar("AAbb"));
            Console.WriteLine(DoubleChar("Hi-There"));
            Console.ReadLine();
        }

        /* Given a string, return a string where for every char in the original, there are two chars. */
        public static string DoubleChar(string str)
        {
            var result = string.Empty;
            for (var i = 0; i < str.Length-1; i++)
            {
                result += str.Substring(i, 1) + str.Substring(i, 1);
            }
            return result;
        }
    }
}
