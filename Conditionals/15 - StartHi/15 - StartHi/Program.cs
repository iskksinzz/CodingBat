using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___StartHi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StartHi("hi there"));
            Console.WriteLine(StartHi("hi"));
            Console.WriteLine(StartHi("high up"));
            Console.ReadLine();
        }

        /* Given a string, return true if the string starts with "hi" and false otherwise. */
        public static bool StartHi(string str)
        {
            return (str.Length < 3 && str.Equals("hi")) || (str.StartsWith("hi") && str[2] == ' ');
        }
    }
}
