using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___RotateRight2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RotateRight("Hello"));
            Console.WriteLine(RotateRight("Csharp"));
            Console.WriteLine(RotateRight("Java"));
            Console.WriteLine(RotateRight("Hi"));
            Console.ReadLine();
        }

        /* Given a string, return a "rotated right 2" version where the last 2 chars are moved to the start. 
         * The string length will be at least 2. 
         */
        public static string RotateRight(string str)
        {
            return str.Substring(str.Length - 2) + str.Substring(0, str.Length - 2);
        }

    }
}
