using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_01
{
    public enum OborStudia
    {
        /// <summary>
        /// Informacni technologie
        /// </summary>
        IT,
        /// <summary>
        /// Management ICT projektu
        /// </summary>
        ICT,
        /// <summary>
        /// Ekonomie a management
        /// </summary>
        EM
    }

    public enum Katedra
    {
        /// <summary>
        /// Katedra informacnich technologii
        /// </summary>
        IT,
        /// <summary>
        /// Katedra ekonomie a managementu
        /// </summary>
        EM
    }

    public class Skola
    {
        public string Nazev { get; set; }
        public List<Predmet> Predmety { get; set; } = new List<Predmet>();
        public List<Ucitel> Ucitele { get; set; } = new List<Ucitel>();
        public List<Student> Studenti { get; set; } = new List<Student>();

        public Skola() { }

        public Skola(string nazev, List<Predmet> predmety, List<Ucitel> ucitele,List<Student> studenti)
        {
            Nazev = nazev;
            Predmety = predmety;
            Ucitele = ucitele;
            Studenti = studenti;
        }
    }
}
