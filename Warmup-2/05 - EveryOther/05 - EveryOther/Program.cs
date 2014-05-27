using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___EveryOther
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EveryOther("Hello"));
            Console.WriteLine(EveryOther("Hi"));
            Console.WriteLine(EveryOther("Heeololeo"));
            Console.ReadLine();
        }

        /* Given a string, return a new string made of every other char starting with the first, so "Hello" yields "Hlo". */
        public static string EveryOther(string str)
        {
            // LINQ
            return str.Where((t, i) => i % 2 == 0).Aggregate(string.Empty, (current, t) => current + t);

            //var result = string.Empty;
            //for (var i = 0; i < str.Length; i++)
            //{
            //    if (i % 2 == 0) result += str[i];
            //}
            //return result;
        }
    }
}
