using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___TakeOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TakeOne("Hello", true));
            Console.WriteLine(TakeOne("Hello", false));
            Console.WriteLine(TakeOne("oh", true));
            Console.ReadLine();
        }

        /* Given a string, return a string length 1 from its front, 
         * unless front is false, in which case return a string length 1 from its back. 
         * The string will be non-empty. 
         */
        public static string TakeOne(string str, bool fromFront)
        {
            return fromFront ? str.Substring(0, 1) : str.Substring(str.Length - 1);
        }
    }
}
