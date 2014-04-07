using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25___EEEEEEE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GotE("Hello"));
            Console.WriteLine(GotE("Heelle"));
            Console.WriteLine(GotE("Heelele"));
            Console.ReadLine();
        }

        /* Return true if the given string contains between 1 and 3 'e' chars. */

        public static bool GotE(string str)
        {
            //var count = str.Split('e').Length - 1;

            // LINQ
            var count = str.Count(s => s == 'e');
            return count <= 3;
        }
    }
}
