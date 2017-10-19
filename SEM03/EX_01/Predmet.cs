using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_01
{
    public class Predmet
    {
        public string Nazev { get; set;}

        public string Anotace { get; set; }
        public int PocetKreditu { get; set; }
        public List<Prednaska> Prednasky { get; set; } = new List<Prednaska>();
        public List<Seminar> Seminare { get; set; } = new List<Seminar>();
        public List<OborStudia> OboryStudia { get; set; } = new List<OborStudia>();

        public Predmet(string nazev,string anotace, int pocetKreditu, List<OborStudia> oboryStudia)
        {
            Nazev = nazev;
            Anotace = anotace;
            PocetKreditu = pocetKreditu;
            OboryStudia = oboryStudia;
        }

        public Predmet(string nazev,string anotace, int pocetKreditu,List<OborStudia> oboryStudia, List<Prednaska> prednasky, List<Seminar> seminare) 
            : this(nazev,anotace,pocetKreditu,oboryStudia)
        {
            Prednasky = prednasky;
            Seminare = seminare;
        }
    }
}
