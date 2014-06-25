using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatDog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CatDog("catdog"));
            Console.WriteLine(CatDog("catcat"));
            Console.WriteLine(CatDog("1cat1cadodog"));
            Console.ReadLine();
        }

        /* Return true if the string "cat" and "dog" appear the same number of times in the given string. */
        public static bool CatDog(string str)
        {
            var cat = 0;
            var dog = 0;

            for (var i = 0; i < str.Length - 2; i++)
            {
                if (str.Substring(i, 3).Equals("cat"))
                {
                    i += 2;
                    cat++;
                    continue;
                }
                if (str.Substring(i, 3).Equals("dog"))
                {
                    i += 2;
                    dog++;
                }
            }
            return cat == dog;
        }
    }
}
