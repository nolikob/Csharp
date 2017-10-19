using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_01
{
    public abstract class Vyuka
    {
        public string Nazev { get; set; }
        public string Anotace { get; set; }
        public DateTime DatumKonani { get; set; }

        public Ucitel Ucitel { get; set; }
        public string MistoKonani { get; set; }
        public Vyuka(string nazev, string anotace, DateTime datumKonani,Ucitel ucitel, string mistoKonani)
        {
            Nazev = nazev;
            Anotace = anotace;
            DatumKonani = datumKonani;
            Ucitel = ucitel;
            MistoKonani = mistoKonani;
        }
    }
}
