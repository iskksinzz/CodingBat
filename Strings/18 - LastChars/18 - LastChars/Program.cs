using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18___LastChars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LastChars("last", "chars"));
            Console.WriteLine(LastChars("yo", "mama"));
            Console.WriteLine(LastChars("hi", ""));
            Console.WriteLine(LastChars("", "hi"));
            Console.ReadLine();
        }

        /* Given 2 strings, a and b, return a new string made of the first char of a and the last char of b, 
         * so "yo" and "java" yields "ya". If either string is length 0, use '@' for its missing char. 
         */
        public static string LastChars(string firstString, string secondString)
        {
            if (string.IsNullOrEmpty(firstString) || string.IsNullOrEmpty(secondString))
            {
                return firstString.Length > 1
                    ? firstString.Substring(0, 1) + "@"
                    : "@" + secondString.Substring(secondString.Length - 1);
            }
            return firstString.Substring(0, 1) + secondString.Substring(secondString.Length -1);
        }
    }
}
