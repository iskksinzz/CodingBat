using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___Between10and20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Bewteen10and20(12, 99));
            Console.WriteLine(Bewteen10and20(21, 12));
            Console.WriteLine(Bewteen10and20(8, 99));
            Console.ReadLine();
        }

        /* Given 2 int values, return true if either of them is in the range 10..20 inclusive. */
        public static bool Bewteen10and20(int a, int b)
        {
            //return Enumerable.Range(10, 20).Contains(a) || Enumerable.Range(10, 20).Contains(b);
            return (a >= 10 && a <= 20) || (b >= 10 && b <= 20);
        }
    }
}
