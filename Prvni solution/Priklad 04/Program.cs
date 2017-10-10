using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priklad_04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napište program, který od uživatele načte postupně dva textové řetězce. 
             * Poté uživateli vypíše, na jaké pozici se vyskytuje druhý řetězec v prvním řetězci.
             */

            Console.Write("Zadejte prvni retezec: ");
            string a = Console.ReadLine();
            Console.Write("Zadejte podretezec: ");
            string b = Console.ReadLine();
            Console.WriteLine(a.IndexOf(b));
            Console.ReadKey();
        }
    }
}
