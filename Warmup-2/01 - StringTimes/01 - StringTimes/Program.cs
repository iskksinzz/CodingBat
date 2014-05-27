using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___StringTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringTimes("Hi", 2));
            Console.WriteLine(StringTimes("Hi", 3));
            Console.WriteLine(StringTimes("Hi", 1));
            Console.ReadLine();
        }

        /* Given a string and a non-negative int n, return a larger string that is n copies of the original string. */

        public static string StringTimes(string str, int n)
        {
            var result = "";
            for (var i = 0; i < n; i++)
            {
                result += str;
            }
            return result;
        }
    }
}
