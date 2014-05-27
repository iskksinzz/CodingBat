using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___RotateLeft2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RotateLeft("Hello"));
            Console.WriteLine(RotateLeft("Csharp"));
            Console.WriteLine(RotateLeft("Programming"));
            Console.ReadLine();
        }

        /* Given a string, return a "rotated left 2" version where the first 2 chars are moved to the end. 
         * The string length will be at least 2. 
         */
        public static string RotateLeft(string str)
        {
            return str.Substring(2) + str.Substring(0, 2);
        }
    }
}
