using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22___MinCat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinCat("Hello", "Hi"));
            Console.WriteLine(MinCat("Hello", "csharp"));
            Console.WriteLine(MinCat("csharp", "Hello"));
            Console.ReadKey();
        }

        /* Given two strings, append them together (known as "concatenation") and return the result.
         * However, if the strings are different lengths, omit chars from the longer string so 
         * it is the same length as the shorter string. So "Hello" and "Hi" yield "loHi". 
         * The strings may be any length. 
         */
        public static string MinCat(string a, string b)
        {
            if (a.Length == b.Length)
                return a + b;

            return a.Length > b.Length ? (a.Substring(a.Length - b.Length) + b) : a + (b.Substring(b.Length - a.Length));
        }
    }
}
