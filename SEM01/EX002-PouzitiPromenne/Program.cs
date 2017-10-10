// EX002 Použití proměnných
// ----------------------------
// vypis obsahu promenne

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX002_PouzitiPromenne
{
    class Program
    {
        static void Main(string[] args)
        {
            // založení proměnné a její inicializace
            string s = "Ahoj";
            // lze nahradit řádky - založení a posléze inicialializace
            //string s;
            //s = "Ahoj";

            // !!! dále již nikdy nezmiňujeme typ proměnné před jejím použitím

            Console.WriteLine(s);

            // druhé použití proměnné
            s = "Dnes mam dobrou naladu.";
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
