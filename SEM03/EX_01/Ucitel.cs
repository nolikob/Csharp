using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_01
{
    public class Ucitel : Osoba
    {
        public Ucitel(string jmeno, string prijmeni, DateTime datumNarozeni, Katedra katedra) : base(jmeno, prijmeni, datumNarozeni)
        {
            Katedra = katedra;
        }
        public Katedra Katedra;
        public override string ToString()
        {
            return String.Format("{0} {1} {2}",Prijmeni,Jmeno,DatumNarozeni.ToString("dd.MM.yyyy"));
        }
    }
}
