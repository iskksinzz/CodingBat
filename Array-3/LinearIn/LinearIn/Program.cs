using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearIn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LinearIn(new[] { 1, 2, 4, 6 }, new[] { 2, 4 }));
            Console.WriteLine(LinearIn(new[] { 1, 2, 4, 6 }, new[] { 2, 3, 4 }));
            Console.WriteLine(LinearIn(new[] { 1, 2, 4, 4, 6 }, new[] { 2, 4 }));
            Console.ReadLine();
        }

        static bool LinearIn(int[] outer, int[] inner)
        {
            if (inner.Length == 0) return true;

            var j = 0;
            foreach (var i in outer)
            {
                if (inner[j] == i) { j++; }
                if (j == inner.Length) { return true; }
            }
            return false;
        }
    }
}
