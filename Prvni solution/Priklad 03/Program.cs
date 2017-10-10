using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priklad_03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napište program, který uživatele postupně vyzve k zadání roku, měsíce a dne. 
             * Poté vytvoříte objekt typu DateTime a zobrazíte tento vytvořený datum uživateli na konzoli.
             * 
             * Rozšiřte původní program na načtení data (příklad 3) o vypsání, jaký je rozdíl počtu dnů aktuálního data od zadaného data.
             */
            DateTime nowTime = DateTime.Now;
            Console.Write("Zadejte rok v cislech: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Zadejte mesic v cislech: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Zadejte den v cislech: ");
            int day = int.Parse(Console.ReadLine());
            DateTime userDate = new DateTime(year, month, day); // aktualni cas
            // zakomentovane je rozsireni o zadani 4
            //TimeSpan difference = nowTime - userDate; // rozdil aktualniho casu a casu od uzivatele
            Console.WriteLine(userDate);
            //Console.WriteLine(difference.Days);
            Console.ReadKey();
        }
    }
}
