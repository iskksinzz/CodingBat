using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___NotString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NotString("candy"));
            Console.WriteLine(NotString("x"));
            Console.WriteLine(NotString("not bad"));

            Console.ReadLine();
        }

        /* Given a string, return a new string where "not " has been added to the front. 
         * However, if the string already begins with "not", return the string unchanged.
         * Hint: Look up how to use "SubString" in c# */

        public static string NotString(string s)
        {
            if (s.Length > 2 && s.Substring(0, 3).Equals("not"))
            {
                return s;
            }
            return "not " + s;
        }
    }
}
