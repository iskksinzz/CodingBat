using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(XyBalance("aaxbby"));
            Console.WriteLine(XyBalance("aaxbb"));
            Console.WriteLine(XyBalance("yaaxbb"));
            Console.ReadLine();
        }

        /* We'll say that a String is xy-balanced if for all the 'x' chars in the string, 
         * there exists a 'y' char somewhere later in the string. So "xxy" is balanced, but "xyx" is not. 
         * One 'y' can balance multiple 'x's. Return true if the given string is xy-balanced. */
        public static bool XyBalance(string str)
        {
            bool y = false;
            for (var i = str.Length - 1; i >= 0; i--)
            {
                if (str[i].Equals('y'))
                    y = true;

                if (str[i].Equals('x') && !y)
                    return false;
            }
            return true;
        }
    }
}
