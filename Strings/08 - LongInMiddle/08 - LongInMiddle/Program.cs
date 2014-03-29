using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___LongInMiddle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongInMiddle("Hello", "Hi"));
            Console.WriteLine(LongInMiddle("Where", "How"));
            Console.WriteLine(LongInMiddle("Why", "When"));
            Console.ReadLine();
        }

        /* Given 2 strings, a and b, return a string of the form short+long+short, 
         * with the shorter string on the outside and the longer string on the inside. 
         * The strings will not be the same length, but they may be empty (length 0). 
         */
        public static string LongInMiddle(string a, string b)
        {
            return a.Length > b.Length ? (b + a + b) : (a + b + a);
        }
    }
}
