using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19___ConCat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConCat("abc", "cat"));
            Console.WriteLine(ConCat("dog", "cat"));
            Console.WriteLine(ConCat("abc", ""));
            Console.WriteLine(ConCat("", "abc"));
            Console.ReadLine();
        }

        /* Given two strings, append them together (known as "concatenation") 
         * and return the result. However, if the concatenation creates a double-char, 
         * then omit one of the chars, so "abc" and "cat" yields "abcat". 
         */
        public static string ConCat(string a, string b)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
            {
                return a + b;
            }
            if (a[a.Length-1] == b[0])
            {
               return a.Remove(a.Length-1) + b;
            }
            return a + b;

        }
    }
}
