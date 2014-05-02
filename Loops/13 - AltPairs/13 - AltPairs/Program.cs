using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _13___AltPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AltPairs("kitten"));
            Console.WriteLine(AltPairs("Chocolate"));
            Console.WriteLine(AltPairs("CodingHorror"));
            Console.ReadLine();
        }

        /* Given a string, return a string made of the chars at indexes 0,1, 4,5, 8,9 ... so "kittens" yields "kien". */
        public static string AltPairs(string str)
        {
            var result = string.Empty;
            for (var i = 0; i < str.Length; i += 4)
            {
                var c = i + 2;
                var n = 0;
                n += c > str.Length ? 1 : 2;
                result += str.Substring(i, n);
            }
            return result;
        }
    }
}