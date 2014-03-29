using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___InsertWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(InsertWord("<<>>", "Hello"));
            Console.WriteLine(InsertWord("[[]]", "World"));
            Console.ReadLine();
        }

        /* Given an "out" string length 4, such as "<<>>", and a word, 
         * return a new string where the word is in the middle of the out string, e.g. "<<word>>".
         */
        public static string InsertWord(string container, string word)
        {
            return (container.Substring(0,2) + word + container.Substring(2));
            
        }
    }
}
