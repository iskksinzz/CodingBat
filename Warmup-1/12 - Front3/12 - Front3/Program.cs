using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___Front3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Front3("Microsoft"));
            Console.WriteLine(Front3("Chocolate"));
            Console.WriteLine(Front3("at"));
            Console.ReadLine();
        }

        /* Given a string, we'll say that the front is the first 3 chars of the string. 
         * If the string length is less than 3, the front is whatever is there. 
         * Return a new string which is 3 copies of the front. */
        public static string Front3(string str)
        {
            return str.Length < 3 ? new StringBuilder().Insert(0, str.Substring(0), 3).ToString() : string.Concat(Enumerable.Repeat(str.Substring(0, 3), 3));
            //return str.Length < 3 ? str + str + str : str.Substring(0, 3) + str.Substring(0, 3) + str.Substring(0, 3);
        }
    }
}
