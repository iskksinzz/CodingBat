using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___StringX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringX("xxHxix"));
            Console.WriteLine(StringX("abxxxcd"));
            Console.WriteLine(StringX("xabxxxcdx"));
            Console.ReadLine();
        }

        /* Given a string, return a version where all the "x" have been removed. 
         * Except an "x" at the very start or end should not be removed. */
        public static string StringX(string str)
        {
            var result = string.Empty;
            for (var i = 0; i < str.Length; i++)
            {
                if (!(i > 0 && i < str.Length - 1 && str.Substring(i, 1).Equals("x")))
                    result += str.Substring(i, 1);
            }
            return result;
        }
    }
}
