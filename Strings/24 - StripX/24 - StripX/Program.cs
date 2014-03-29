using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24___StripX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StripX("xHix"));
            Console.WriteLine(StripX("xHi"));
            Console.WriteLine(StripX("Hxix"));
            Console.WriteLine(StripX("lol"));
            Console.ReadKey();
        }

        /* Given a string, if the first or last chars are 'x', return the string without
         * those 'x' chars, and otherwise return the string unchanged. 
         */
        public static string StripX(string str)
        {  
            if (str.First().Equals('x') && str.Last().Equals('x'))
            {
                return str.Substring(1, str.Length-2);
            }
            else if (str[0] == 'x')
            {
                return str.Substring(1);
            }
            else if (str.Last().Equals('x'))
            {
                return str.Substring(0, str.Length-1);
            }
            return str;
        }
    }
}
