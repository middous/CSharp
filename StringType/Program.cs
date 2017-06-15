using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringType
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString1 = "yes it is";
            string myString = @" This is my\v String\\Thisis\ agood courxse\n";
            string myString2 = myString1 + myString;
            
            Console.WriteLine("{0}", myString2);
        }
    }
}
