using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___AlarmClock
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AlarmClock(1, false));
            Console.WriteLine(AlarmClock(5, false));
            Console.WriteLine(AlarmClock(0, false));
            Console.ReadLine();
        }

        /* Given a day of the week encoded as 0=Sun, 1=Mon, 2=Tue, ...6=Sat, and a boolean indicating 
         * if we are on vacation, return a string of the form "7:00" indicating when the alarm clock should ring. 
         * Weekdays, the alarm should be "7:00" and on the weekend it should be "10:00". 
         * Unless we are on vacation -- then on weekdays it should be "10:00" and weekends it should be "off". */
        public static string AlarmClock(int day, bool vacation)
        {
            if (!vacation)
                return day >= 1 && day < 6 ? "7:00" : "10:00";
            return day >= 1 && day < 6 ? "10:00" : "off";
        }
    }
}
