using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literal_Char
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar = -100;
            uint myUVar = 1000u;
            ulong myLVar = 1000L;

            float myFlVar = 1.5f;
            double myDVar = 100.5d;
            decimal myDCVar = 100.5m;
            Console.WriteLine("{0},{1},{2},{3},{4},{5}", myVar, myUVar, myLVar,myFlVar,myDVar,myDCVar);
            Console.WriteLine($"{myDCVar},{myDVar}");
        }
    }
}
