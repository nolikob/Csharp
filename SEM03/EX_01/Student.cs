using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_01
{
    public class Student : Osoba
    {
        public Student(string jmeno, string prijmeni, DateTime datumNarozeni, OborStudia oborStudia) : base(jmeno, prijmeni, datumNarozeni)
        {
            OborStudia = oborStudia;
        }
        public OborStudia OborStudia;
    }
}
