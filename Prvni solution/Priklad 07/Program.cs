using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priklad_07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napište program, který získá od uživatele řetězec. 
             * Dále od uživatele získá informaci, jaký podřetězec má nahradit a nahrazovaný podřetězec. 
             * Výsledek operace poté vypište na konzoli.
             */
            string s = Console.ReadLine();
            string toChange = Console.ReadLine();
            string withWhat = Console.ReadLine();
            Console.WriteLine(s.Replace(toChange, withWhat));
            Console.ReadKey();
        }
    }
}
