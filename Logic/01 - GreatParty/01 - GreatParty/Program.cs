using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___GreatParty
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GreatParty(30, false));
            Console.WriteLine(GreatParty(50, false));
            Console.WriteLine(GreatParty(70, true));
            Console.ReadLine();
        }

        /* When squirrels get together for a party, they like to have cigars. 
         * A squirrel party is successful when the number of cigars is between 40 and 60, inclusive. 
         * Unless it is the weekend, in which case there is no upper bound on the number of cigars. 
         * Return true if the party with the given values is successful, or false otherwise. */

        public static bool GreatParty(int cigars, bool isWeekend)
        {
            return isWeekend && cigars >= 40 || !isWeekend && cigars >= 40 && cigars <= 60;
        }
    }
}