using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___MischeviousChildren
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AreWeInTrouble(true, true));
            Console.WriteLine(AreWeInTrouble(false, false));
            Console.WriteLine(AreWeInTrouble(true, false));
            Console.ReadLine();
        }

        /* We have two children, a and b, and the parameters aSmile and bSmile indicate if each is smiling.
         * We are in trouble if they are both smiling or if neither of them is smiling.
         * Return true if we are in trouble. */

        public static bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            if (aSmile && bSmile)
            {
                return true;
            }
            else if (!aSmile && !bSmile)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
