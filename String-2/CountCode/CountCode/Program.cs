using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountCode("aaacodebbb"));
            Console.WriteLine(CountCode("codexxcode"));
            Console.WriteLine(CountCode("cozexxcope"));
            Console.ReadLine();
        }

        /* Return the number of times that the string "code" appears anywhere in the given string, 
         * except we'll accept any letter for the 'd', so "cope" and "cooe" count. */
        public static int CountCode(string str)
        {
            var count = 0;
            for (var i = 0; i < str.Length; i++)
            {
                if (str.Substring(i, 1).Equals("c") && str.Substring(i + 1, 1).Equals("o") && str.Substring(i + 3, 1).Equals("e"))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
