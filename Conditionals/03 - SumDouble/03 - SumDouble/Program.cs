using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___SumDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumDouble(1,2));
            Console.WriteLine(SumDouble(3,2));
            Console.WriteLine(SumDouble(2,2));
            Console.ReadLine();
        }

        public static int SumDouble(int a, int b)
        {
            return a == b ? (a + b)*2 : a + b;
        }
    }
}
