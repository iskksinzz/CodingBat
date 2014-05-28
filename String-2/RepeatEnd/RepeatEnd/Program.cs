using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RepeatEnd("Hello", 3));
            Console.WriteLine(RepeatEnd("Hello", 2));
            Console.WriteLine(RepeatEnd("Hello", 1));
            Console.ReadLine();
        }

        /* Given a string and an int N, return a string made of N repetitions of the last N characters of the string. 
         * You may assume that N is between 0 and the length of the string, inclusive. */
        public static string RepeatEnd(string str, int n)
        {
            var result = string.Empty;
            var end = str.Substring(str.Length - n);
            for (var i = 0; i < n; i++)
            {
                result += end;
            }
            return result;
        }
    }
}
