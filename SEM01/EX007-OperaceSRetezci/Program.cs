// EX007 Operace s řetězci
// ----------------------------
// Různé základní operace s řetězci

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX007_OperaceSRetezci
{
    class Program
    {
        static void Main(string[] args)
        {
            // vybírání podřetězců
            string s = "<cool>Unicorn College</cool>";
            int start = s.IndexOf(">");
            int end = s.LastIndexOf("<") - start;
            string cool = s.Substring(start+1).Substring(0,end - 1);
            Console.WriteLine("Výsledek: {0}", cool);

            // nahrazování částí
            string t = s.Replace("cool", "most_cool");
            Console.WriteLine("Výsledek: {0}", t);

            // délky
            Console.WriteLine("Výsledek: {0} {1}", s.Length, t.Length);

            // zvětšení a zmenšení
            Console.WriteLine("Výsledek: {0} {1} {2}", cool, cool.ToUpper(), cool.ToLower());

            Console.ReadKey();
        }
    }
}
