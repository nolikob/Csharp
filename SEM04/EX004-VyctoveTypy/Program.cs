using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace EX004_VyctoveTypy
{
    
    enum Ovoce
    { 
        Jablko, Hruska, Pomeranc, Mandarinka
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ovoce o = Ovoce.Hruska;

            switch (o)
            {
                case Ovoce.Jablko:
                    Console.WriteLine("Akce pro jablko");
                    break;
                case Ovoce.Hruska:
                    Console.WriteLine("Akce pro hrusku");
                    break;
                case Ovoce.Pomeranc:
                    Console.WriteLine("Akce pro pomeranc");
                    break;
                case Ovoce.Mandarinka:
                    Console.WriteLine("Akce pro mandarinku");
                    break;
            }
            Console.WriteLine(o.ToString());
            Console.ReadKey();
        }
    }
}

