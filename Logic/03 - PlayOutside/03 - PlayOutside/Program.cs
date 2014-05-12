using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___PlayOutside
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PlayOutside(70, false));
            Console.WriteLine(PlayOutside(95, false));
            Console.WriteLine(PlayOutside(95, true));
            Console.ReadLine();
        }

        /* The children in Cleveland spend most of the day playing outside. 
         * In particular, they play if the temperature is between 60 and 90 (inclusive). 
         * Unless it is summer, then the upper limit is 100 instead of 90. Given an int 
         * temperature and a bool isSummer, return true if the children play and false otherwise. */
        public static bool PlayOutside(int temp, bool isSummer)
        {
            return isSummer && temp >= 60 && temp <= 100 || temp >= 60 && temp <= 90;
        }
    }
}
