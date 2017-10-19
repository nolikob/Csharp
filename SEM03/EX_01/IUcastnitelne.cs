using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_01
{
    public interface IUcastnitelne
    {
        bool Prihlas(Student student);
        void Odhlas(Student student);
        List<Student> PrihlaseniStudenti { get; }
        int PocetPrihlasenych { get; }
        Student this[int index] { get; }
    }
}
