using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Testovaci data
            Ucitel ucitelkaJana = new Ucitel("Jana", "Sykorova", new DateTime(1972, 5, 30), Katedra.EM);
            Ucitel ucitelKarel = new Ucitel("Karel", "Novak", new DateTime(1986, 11, 8), Katedra.IT);
            Console.WriteLine(ucitelKarel.ToString());
            Console.ReadKey();
            List<Prednaska> prednaskyCSP = new List<Prednaska>();
            prednaskyCSP.Add(new Prednaska("Uvod do C# .NET", "V teto prednasce se seznamite se zaklady C# a predstavime si ...",
                new DateTime(2016, 10, 10), ucitelKarel, "PAR 1.1", "www.uclstreams.cz/csp1"));
            prednaskyCSP.Add(new Prednaska("OOP v C#", "V teto prednasce se seznamite s OOP v C# a rozsirite si sve znalosti ...",
                new DateTime(2016, 10, 17), ucitelKarel, "PAR 1.1", "www.uclstreams.cz/csp2"));

            List<Seminar> seminareCSP = new List<Seminar>();
            seminareCSP.Add(new Seminar("Visual Studio a C# .NET", "V tomto seminari se seznamite s vyvojovym prostredim ...",
                new DateTime(2016, 10, 12), ucitelKarel, "PAR 0.1", 0));
            seminareCSP.Add(new Seminar("OOP v C#", "V tomto seminari si procvicite ...",
                new DateTime(2016, 10, 19), ucitelKarel, "PAR 0.1", 5));

            List<Predmet> predmety = new List<Predmet>();
            predmety.Add(new Predmet("Vyvoj v C# .NET", "V tomto predmetu se naucite programovaci jazyk C# a zaklady platformy .NET a ...",
                6, new List<OborStudia>(new OborStudia[] { OborStudia.IT, OborStudia.ICT }), prednaskyCSP, seminareCSP));

            List<Prednaska> prednaskyMIE = new List<Prednaska>();
            prednaskyMIE.Add(new Prednaska("Uvod do Mikroekonomie", "V teto prednasce se seznamite s tim, cim se zabyva ...",
                new DateTime(2016, 10, 4), ucitelkaJana, "PAR 1.1", "www.uclstreams.cz/mie1"));
            prednaskyMIE.Add(new Prednaska("Optimum spotrebitele", "V teto prednasce se seznamite s tim, jak se ...",
                new DateTime(2016, 10, 11), ucitelkaJana, "PAR 1.1", "www.uclstreams.cz/mie2"));

            List<Seminar> seminareMIE = new List<Seminar>();
            seminareMIE.Add(new Seminar("Uvod do Mikroenokomie", "V tomto seminari si procvicite ...",
                new DateTime(2016, 10, 6), ucitelkaJana, "PAR 1.1", 2));
            seminareMIE.Add(new Seminar("Optimum spotrebitele", "V tomto seminari si procvicite ...",
                new DateTime(2016, 10, 13), ucitelkaJana, "PAR 1.1", 5));

            predmety.Add(new Predmet("Mikroekonomie 1", "V tomto predmetu se naucite zaklady mikroekonomie. Budeme se zabyvat ...",
                6, new List<OborStudia>(new OborStudia[] { OborStudia.EM })));

            List<Student> studenti = new List<Student>();
            studenti.Add(new Student("Petr", "Smid", new DateTime(1991, 8, 15), OborStudia.IT));
            studenti.Add(new Student("Anna", "Kalinova", new DateTime(1991, 8, 15), OborStudia.ICT));
            studenti.Add(new Student("Lucie", "Pokorna", new DateTime(1991, 8, 15), OborStudia.EM));

            Skola skola = new Skola("Unicorn College", predmety, new List<Ucitel>(new Ucitel[] { ucitelkaJana, ucitelKarel }),studenti);
            
        }
    }
}
