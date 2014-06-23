using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatFront
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RepeatFront("Chocolate", 4));
            Console.WriteLine(RepeatFront("Chocolate", 3));
            Console.WriteLine(RepeatFront("Ice Cream", 2));
            Console.ReadLine();
        }

        /* Given a string and an int n, return a string made of the first n characters of the string, 
         * followed by the first n-1 characters of the string, and so on. 
         * You may assume that n is between 0 and the length of the string, inclusive. */
        public static string RepeatFront(string str, int n)
        {
            var result = str.Substring(0, n);
            for (var i = 1; i < n; i++)
            {
                result += str.Substring(0, n - i);
            }
            return result;
        }
    }
}
