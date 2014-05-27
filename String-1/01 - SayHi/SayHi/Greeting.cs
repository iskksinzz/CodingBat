using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayHi
{
    class Greeting
    {
        /* Given a string name, e.g. "Bob", return a greeting of the form "Hello Bob!". 
         */
        public string SayHi(string name)
        {
            Console.WriteLine("Hello {0}!", name);
            return name;
        }
    }
}
