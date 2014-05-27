using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___ParrotTrouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ParrotTrouble(true, 6));
            Console.WriteLine(ParrotTrouble(true, 7));
            Console.WriteLine(ParrotTrouble(false, 6));
            Console.ReadLine();
        }

        /* We have a loud talking parrot. The "hour" parameter is the current hour time in the range 0..23.
         * We are in trouble if the parrot is talking and the hour is before 7 or after 20. 
         * Return true if we are in trouble. */

        public static bool ParrotTrouble(bool isTalking, int hour)
        {
            if (isTalking && hour < 7 || (hour > 20))
            {
                return true;
            }
            return false;;
        }
    }
}
