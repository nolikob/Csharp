using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priklad_06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napište program, který od uživatele nejprve získá jeden řetězec. 
             * Dále od uživatele načte dvě čísla, která budou znamenat pozici a počet znaků vybíraného podřetězce. Vypíšete podřetězec vymezený zadanými dvěma čísly.
             */
            Console.Write("Zadejte retezec: ");
            string s = Console.ReadLine();
            Console.WriteLine("Zadejte pozici v retezci: ");
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte pocet znaku: ");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine(s.Substring(position, amount));
            Console.ReadKey();
        }
    }
}
