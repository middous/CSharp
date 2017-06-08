using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTFloatPointTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            float flMin = float.MinValue;
            float flMax = float.MaxValue;
            Console.WriteLine("min value = {0} Max val = {1}", flMin, flMax);

            float flVar = 1F / 3;
            double dlVar = 1D / 3;
            decimal dcVar = 1M / 3;
            Console.WriteLine("\n F = {0}\n d = {1}\n de = {2}", flVar, dlVar, dcVar);
        }
    }
}
