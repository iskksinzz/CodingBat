using System;

namespace _11___FrontBack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FrontBack("code"));
            Console.WriteLine(FrontBack("a"));
            Console.WriteLine(FrontBack("ab"));
            Console.ReadLine();
        }

        /* Given a string, return a new string where the first and last chars have been exchanged.  */

        public static string FrontBack(string str)
        {
            //if (str.Length <= 1) return str;
            //var mid = str.Substring(1, str.Length - 2);
            //return str[(str.Length - 1)] + mid + str[0];

            return str.Length > 1
                ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
        }
    }
}
