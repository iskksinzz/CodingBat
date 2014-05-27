using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___MakeTags
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MakeTags("i", "Hello"));
            Console.ReadLine();
        }

        /* The web is built with HTML strings like "<i>Yay</i>" which draws Yay as italic text. 
         * In this example, the "i" tag makes <i> and </i> which surround the word "Yay". 
         * Given tag and word strings, create the HTML string with tags around the word, e.g. "<i>Yay</i>". 
         */
        private static string MakeTags(string tag, string content)
        {
            return tag + content + tag;
        }
    }
}
