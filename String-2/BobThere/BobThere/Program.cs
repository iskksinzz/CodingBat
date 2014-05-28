using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobThere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BobThere("abcbob"));
            Console.WriteLine(BobThere("b9b"));
            Console.WriteLine(BobThere("bac"));
            Console.ReadLine();
        }

        /* Return true if the given string contains a "bob" string, 
         * but where the middle 'o' char can be any char. */
        public static bool BobThere(string str)
        {
            for (var i = 0; i < str.Length; i++)
            {
                if (str[i] == 'b' && str[i + 2] == 'b') 
                    return true;
            }
            return false;
        }
    }
}
