using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___EndsWithLy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EndsWithLy("Hello"));
            Console.WriteLine(EndsWithLy("Oddly"));
            Console.WriteLine(EndsWithLy("oddy"));
            Console.WriteLine(EndsWithLy("y"));
            Console.WriteLine(EndsWithLy("ly"));
            Console.ReadLine();
        }

        /* Given a string, return true if it ends in "ly". 
         */
        public static bool EndsWithLy(string str)
        {
            return str.EndsWith("ly");
        }
    }
}
