using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StarOut("ab*cd"));
            Console.WriteLine(StarOut("ab**cd"));
            Console.WriteLine(StarOut("sm*eilly"));
            Console.ReadLine();
        }

        /* Return a version of the given string, where for every star (*) in the string the star and the chars 
         * immediately to its left and right are gone. So "ab*cd" yields "ad" and "ab**cd" also yields "ad".  */

        public static string StarOut(string str)
        {
            var result = string.Empty;
            for (var i = 0; i < str.Length; i++)
            {
                if (str[i] == '*') continue;
                if (i > 0 && str[i - 1] == '*') continue;
                if (i < str.Length - 1 && str[i + 1] == '*') continue;

                result += str[i];
            }
            return result;
        }
    }
}