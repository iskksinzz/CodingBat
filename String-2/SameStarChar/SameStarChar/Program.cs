using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SameStarChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SameStarChar("xy*yzz"));
            Console.WriteLine(SameStarChar("xy*zzz"));
            Console.WriteLine(SameStarChar("*xa*az"));
            Console.ReadLine();
        }

        /* Returns true if for every '*' (star) in the string, if there are chars both 
         * immediately before and after the star, they are the same. */
        public static bool SameStarChar(string str)
        {
            for (var i = 1; i < str.Length-1; i++)
            {
                if (str[i] == '*' && str[i - 1] != str[i + 1]) return false;
            }
            return true;
        }
    }
}
