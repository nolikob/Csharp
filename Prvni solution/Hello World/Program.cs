using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{   
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napište program, který od uživatele načte dvě čísla a vypíše jejich součet, rozdíl, součin a podíl. 
             * Výpis bude ve formátu a + b = c. Kde a + b nahradíte od uživatele načtenými čísly, c nahradíte výsledkem.
             */
            int a;
            int b;
            Console.WriteLine("Zadejte prvni cislo");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte druhe cislo");
            b = int.Parse(Console.ReadLine());
            // c je soucet
            int c = a + b;
            // d je rozdil
            int d = a - b;
            // e je soucin
            int e = a * b;
            // f je podil
            double f = a / b;
            Console.WriteLine(" Soucet {0} a {1} je : {2} \n Rozdil cisel {0} a {1} je {3} \n Soucin cisel {0} a {1} je {4} \n Podil cisel {0} a {1} je {5}", a, b, c, d, e, f);
            Console.ReadKey();
        }
    }
}
