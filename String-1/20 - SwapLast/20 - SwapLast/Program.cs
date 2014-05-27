using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20___SwapLast
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SwapLast("coding"));
            Console.WriteLine(SwapLast("hello"));
            Console.ReadKey();
        }

        /* Given a string of any length, return a new string where the last 2 chars, 
         * if present, are swapped, so "coding" yields "codign". 
         */
        public static string SwapLast(string str)
        {
            StringBuilder sb = new StringBuilder(str);
            var s1 = str[str.Length - 1];
            var s2 = str[str.Length - 2];

            sb[str.Length - 2] = s1;
            sb[str.Length - 1] = s2;

            return sb.ToString();
        }
    }
}
