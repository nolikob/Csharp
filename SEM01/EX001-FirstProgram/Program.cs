// EX001 První ukázkový program
// ----------------------------
// vypisuje Ahoj 

// standardně připojované "balíky"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// prostredí ve kterém je hlavní třída programu definována
namespace EX001_FirstProgram
{
    // hlavní třída programu
    class Program
    {
        // přístupová metoda pro spouštěč - tuto s daným názvem hledá a pokusí se jí spustit
        static void Main(string[] args)
        {
            // ze třídy Console (z balíku System) použijeme (voláme) metodu WriteLine s parametrem "Hello World!"
            Console.WriteLine("Hello World!");
            // čekáme na stisk klávesy - opět metoda s dané třídy
            Console.ReadKey();
        }
    }
}
