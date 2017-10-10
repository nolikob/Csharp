using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priklad_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napište program, který získá aktuální datum a na konzoli a postupně vypíše rok, měsíc a den na jednotlivé řádky pod sebe. 
             * Jednotlivé výpisy budou odděleny tím, že uživatel musí stisknout libovolnou klávesu.
             */
            DateTime today = DateTime.Now;
            Console.WriteLine(today.Year);
            Console.ReadKey();
            Console.WriteLine(today.Month);
            Console.ReadKey();
            Console.WriteLine(today.Day);
            Console.ReadKey();
        }
    }
}
