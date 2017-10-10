using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priklad_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pro zadaný intervalu <a,b> kde a,b  vypiště součet čísel, které jsou sudé a dělitelné 5.
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = a; i <= b; i++) // lze pouzit i mmodulo 10
            {
                if (i % 2 == 0 && i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Soucet cisel je: {0}", sum);
            Console.ReadKey();
        }
    }
}
