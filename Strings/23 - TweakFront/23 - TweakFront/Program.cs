using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23___TweakFront
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TweakFront("Hello"));
            Console.WriteLine(TweakFront("away"));
            Console.WriteLine(TweakFront("abed"));
            Console.WriteLine(TweakFront("xbed"));
            Console.WriteLine(TweakFront(""));
            Console.ReadKey();
        }

        /* Given a string, return a version without the first 2 chars.
         * Except keep the first char if it is 'a' and keep the second char if it is 'b'. The string may be any length.
         */
        public static string TweakFront(string str)
        {
            if (string.IsNullOrEmpty(str) || str[0] == 'a' && str[1] == 'b')
            {
                return str;
            }
            else if (str[0] != 'a' && str[1] != 'b')
            {
                return str.Substring(2);
            }
            else if (str[0] == 'a')
            {
                return str[0] + str.Substring(2);
            }
            return str[1] + str.Substring(2);
        }
    }
}
