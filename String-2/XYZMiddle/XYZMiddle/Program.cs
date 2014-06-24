using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZMiddle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(XyzMiddle("AAxyzBB"));
            Console.WriteLine(XyzMiddle("AxyzBB"));
            Console.WriteLine(XyzMiddle("AxyzBBB"));
            Console.ReadLine();
        }

        /* Given a string, does "xyz" appear in the middle of the string? To define middle, 
         * we'll say that the number of chars to the left and right of the "xyz" must differ by at most one. */
        public static bool XyzMiddle(string str)
        {
            if (str.Length % 2 == 0)
            {
                return str.Substring(((str.Length / 2) - 2), 3).Equals("xyz") ||
                       str.Substring(((str.Length / 2) - 1), 3).Equals("xyz");
            }
            return str.Substring(((str.Length / 2) - 1), 3).Equals("xyz");
        }
    }
}
