using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___CountLast2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountLast2("hixxhi"));
            Console.WriteLine(CountLast2("xaxxaxaxx"));
            Console.WriteLine(CountLast2("axxxaaxx"));
            Console.ReadLine();
        }

        /* Given a string, return the count of the number of times that a substring length 2
         * appears in the string and also as the last 2 chars of the string, 
         * so "hixxxhi" yields 1 (we won't count the end substring). */

        public static int CountLast2(string str)
        {
            var lastTwo = str.Substring(str.Length-2);
            var count = 0;

            for (var i = 0; i < str.Length-2; i++)
            {
               if (str.Substring(i, 2).Equals(lastTwo)) count++;
            }
            return count;
        }
    }
}