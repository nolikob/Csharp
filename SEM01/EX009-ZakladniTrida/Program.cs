// EX009 Základní třída
// ----------------------------
// Příklad základní třídy definované v C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EX009_ZakladniTrida
{
    // ukazkova trida reprezentujici telefon
    class Telefon
    {
        // ---------- instancni promenne ---------
        // retezec definujici znacku
        string znacka;
        // retezec definujici barvu
        string barva;

        // vydrz baterie v sekundach (pro zkousku)
        double vydrzBaterie;
        // posledni cas nabiti
        DateTime casNabiti;

        // -------------------- Konstruktor ------------------------
        // konstruktur (a la Ruby inicialization) s parametry
        public Telefon(string aZnacka, string aBarva, double aVydrzBaterie)
        {
            znacka = aZnacka;
            barva = aBarva;
            vydrzBaterie = aVydrzBaterie;
            casNabiti = DateTime.Now;
        }


        // --------------------- Metody -------------------------
        // vraci znacku telefonu
        public string vratZnacku()
        {
            return znacka;
        }

        // vraci barvu telefonu
        public string vratBarvu()
        {
            return barva;
        }

        // aktualne dobije telefon
        public void dobij()
        {
            casNabiti = DateTime.Now;
        }

        // vraci zbyvajici cas nez dojde k vybiti v minutach (zaporne hodnoty vyjadruji dobu, jak dlouho 
        // je telefon jiz vybit)
        public int zbyvajiciCas()
        {
            // cas nabiti + vydrz baterie = maximalni cas, do kdy je telefon funkcni, odecteme-li
            // aktualni cas, ziskame bud pozitivni hodnotu doby, jak dlouho jeste vydrzi nebo negativni,
            // vyjadrujici, jak dlouho jiz je vybit
            TimeSpan rozdil = TimeSpan.FromSeconds(casNabiti.Second + vydrzBaterie - DateTime.Now.Second);

            return rozdil.Seconds;
        }

    }


    // Trida testujici jednoduchou tridu Telefon
    class Program
    {
        static void Main(string[] args)
        {
            // zalozeni objektu t typu Telefon
            Telefon t = new Telefon("Founa", "zelenkavy", 4);

            // pomocne uspani na 5000 ms
            Thread.Sleep(5000);  

            // vypis znacky a barvy
            Console.WriteLine("Znacka {0} barva {1}", t.vratZnacku(), t.vratBarvu());

            // vypis zbyvajiciho casu (originalni nastaveni vydrze na 4 s a uspani na 5 s bude mit vysledek v -1 s zbyvajiciho casu
            Console.WriteLine("Zbyva {0} s", t.zbyvajiciCas());

            Console.ReadKey();
        }
    }
}
