// EX006 Čtení čísel
// ----------------------------
// čtení čísel z řetězců

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX006_CteniCisel
{
    class Program
    {
        static void Main(string[] args)
        {
            // konverze řetězce na celé číslo
            string s = " 3           ";
            string t = s.Trim();
            double d = double.Parse(t);
            Console.WriteLine("Konverze řetězce '{0}' na řetězec '{1}' a číslo {2}", s, t, d);

            // konverze řetězce na reálné číslo
            s = " 3,12  ";
            t = s.Trim();
            d = double.Parse(t);
            Console.WriteLine("Konverze řetězce '{0}' na řetězec '{1}' a číslo {2}", s, t, d);


            // Načtení čísla z konzole
            Console.Write("Zadejte číslo: ");
            s = Console.ReadLine();
            t = s.Trim();
            d = double.Parse(t);
            Console.WriteLine("Konverze řetězce '{0}' na řetězec '{1}' a číslo {2}", s, t, d);

            Console.ReadKey();
        }
    }
}
