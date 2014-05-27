using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___FirstHalf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstHalf("WooHoo"));
            Console.WriteLine(FirstHalf("HelloThere"));
            Console.WriteLine(FirstHalf("abcdef"));
            Console.ReadLine();
        }

        /* Given a string of even length, return the first half. So the string "WooHoo" yields "Woo". 
         */
        public static string FirstHalf(string str)
        {
            return str.Substring(0, str.Length / 2);
        }
    }
}
