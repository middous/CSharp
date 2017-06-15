using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int CharMain = Char.MinValue;
            int CharMax = Char.MaxValue;

            char myVar = 'G';
            int myVarVal = 'G';
            Char myVaral = Convert.ToChar(71);
            Console.WriteLine("M c = {0}, M C = {1} My C = {2} my Va n 3 = {3} my Conver var {4}", CharMain, CharMax, myVar, myVarVal, myVaral);

            string mySt = "my string";
            Console.WriteLine("My string is {0}", mySt);

            bool myBo = false;
            Console.WriteLine("my bool is {0}", myBo);
            Console.ReadKey();
        }
    }
}
