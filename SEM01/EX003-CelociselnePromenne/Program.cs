// EX003 Použití celočíselných proměnných
// ----------------------------
// výpis výsledků operace

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX003_CelociselnePromenne
{
    class Program
    {
        static void Main(string[] args)
        {
            // zavedení číselných proměnných
            int a = 3;
            int b = 4;
            int d = a + b;

            // lze i složitější operace
            //d = a * b / 2 + d;

            string s = "Soucet " + a + " + " + b + " = " + d;
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
