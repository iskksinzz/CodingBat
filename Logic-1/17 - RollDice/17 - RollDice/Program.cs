using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___RollDice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RollDice(2, 3, true));
            Console.WriteLine(RollDice(3, 3, true));
            Console.WriteLine(RollDice(3, 3, false));
            Console.ReadLine();
        }

        /* Return the sum of two 6-sided dice rolls, each in the range 1..6. 
         * However, if noDoubles is true, if the two dice show the same value, 
         * increment one die to the next value, wrapping around to 1 if its value was 6. */
        public static int RollDice(int die1, int die2, bool noDoubles)
        {
            if (noDoubles && die1 == die2)
                if (die1 > 5)
                    die1 = 1;
                else
                    die1 += 1;
            return die1 + die2;
        }
    }
}
