using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21___IxStart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IxStart("mix snacks"));
            Console.WriteLine(IxStart("pix snacks"));
            Console.WriteLine(IxStart("piz snacks"));
            Console.ReadLine();
        }

        /* Return true if the given string begins with "*ix", the '*' can be anything, so "pix", "9ix" .. all count. */
        public static bool IxStart(string str)
        {
            return str.Substring(1, 2).Equals("ix");
        }
    }
}
