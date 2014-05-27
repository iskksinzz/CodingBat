using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22___StartOz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StartOz("ozymandias"));
            Console.WriteLine(StartOz("bzoo"));
            Console.WriteLine(StartOz("oxx"));
            Console.ReadLine();
        }

        /* Given a string, return a string made of the first 2 chars (if present), 
         * however include first char only if it is 'o' and include the second only 
         * if it is 'z', so "ozymandias" yields "oz". */
        public static string StartOz(string str)
        {
            var result = "";

            if (str.Length >= 1 && str[0] == 'o') 
                result += str[0];

            if (str.Length >= 2 && str[1] == 'z')
                result += str[1];

            return result;

        }
    }
}
