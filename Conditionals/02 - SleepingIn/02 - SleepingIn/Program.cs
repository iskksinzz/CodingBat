using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___SleepingIn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SleepingIn(false, false));
            Console.WriteLine(SleepingIn(true, false));
            Console.WriteLine(SleepingIn(false, true));
            Console.ReadLine();
        }

        /* The parameter weekday is true if it is a weekday, and the parameter vacation is true if we are on vacation.
         * We sleep in if it is not a weekday or we're on vacation.
         * Return true if we sleep in. */

        public static bool SleepingIn(bool isWeekday, bool isVacation)
        {
            if (!isWeekday && !isVacation)
            {
                return true;
            }
            else if (isWeekday && !isVacation)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
