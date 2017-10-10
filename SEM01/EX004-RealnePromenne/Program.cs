// EX004 Použití realných proměnných
// ----------------------------
// výpis výsledků operace

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace EX004_RealnePromenne
{
    class Program
    {
        static void Main(string[] args)
        {
            // celočíselné proměnné
            double a = 3.14;
            double b = 2.69;
            double d = a + b;

            // složitější operace
            //d = a + 2 * b / d;

            string s = "Soucet " + a + " + " + b + " = " + d;
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
