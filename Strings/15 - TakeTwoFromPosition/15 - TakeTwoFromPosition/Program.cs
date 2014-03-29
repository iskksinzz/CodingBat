using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___TakeTwoFromPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TakeTwoFromPosition("heya", 0));
            Console.WriteLine(TakeTwoFromPosition("1234", 2));
            Console.WriteLine(TakeTwoFromPosition("code", 3));
            Console.ReadLine();
        }

        /* Given a string and an index, return a string length 2 starting at the given index.
         * If the index is too big or too small to define a string length 2, use the first 2 chars. 
         * The string length will be at least 2.
         */
        public static string TakeTwoFromPosition(string str, int n)
        {
            if (n <= 0 || n + 2 > str.Length)
                return str.Substring(0, 2);
            else
                return str.Substring(n);
        }
    }
}
