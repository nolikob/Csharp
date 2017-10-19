using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_01
{
    public abstract class Osoba
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime DatumNarozeni { get; set; }

        public string CeleJmeno
        {
            get { return String.Format("{0} {1}", Jmeno, Prijmeni); }
        }

        public Osoba(string jmeno,string prijmeni,DateTime datumNarozeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            DatumNarozeni = datumNarozeni;
        }
    }
}
