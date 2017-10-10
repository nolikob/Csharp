// EX007 DateTime
// ----------------------------
// Využití objektů DateTime a TimeSpan pro manipulaci s datumem a časem

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX008_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // získání dneška a teďka
            DateTime d = DateTime.Now;
            DateTime t = DateTime.Today;
            Console.WriteLine("Pravě je {0}  -  {1}", d,t);

            // operace s časem
            DateTime e = d.AddDays(1);
            Console.WriteLine("Přidán den {0}", e);
            e = d.AddDays(2.5);
            Console.WriteLine("Přidán 2,5 dne {0}", e);
            e = d.AddHours(0.5).AddSeconds(20.5);
            Console.WriteLine("Přidána půlhodina a 20,5 sekundy {0}", e);
            e = d.AddYears(1).AddTicks(3);
            Console.WriteLine("Přidán rok a 3 setiny {0}", e);

            // přidání rozdílů => TimeSpan
            TimeSpan r = e - t;
            DateTime q = d + r;
            // případně
            //DateTime q = d.Add(r);
            Console.WriteLine("K {0} přidán rozíl {1} = {2}", d, r, q);

            // Zjištění stáří
            TimeSpan ts = DateTime.Now - (new DateTime(1997, 6, 7));
            Console.WriteLine("Věk je {0} let", ts.Days / 365);

            Console.ReadKey();
        }
    }
}
