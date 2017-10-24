using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EX007_Seznam
{
    class Program
    {
        public class Osoba
        {
            public string Jmeno { get; private set; }
            public string Prijmeni { get; private set; }
            public DateTime Narozeni { get; private set; }

            public Osoba(string jmeno, string prijmeni, DateTime narozeni)
            {
                Jmeno = jmeno;
                Prijmeni = prijmeni;
                Narozeni = narozeni;
            }

            public override string ToString()
            {
                return String.Format("{0} {1}", Prijmeni, Jmeno);
            }

        }

        static void Main(string[] args)
        {

            // obecne zvětšovací pole bez genericity
            // lze bez problémů přiřazovat i vypisovat
            ArrayList pole = new ArrayList();
            pole.AddRange(new int[] {54,4,2,5,6,23,2});
            Console.Write(" Pole:");
            foreach (int x in pole)
                Console.Write(" {0}",x);
            Console.WriteLine();
            // ale nejde prostým způsobem získat  - nutná konverze
            //int d = pole[3];
            int d = (int)pole[3];
            Console.WriteLine(" Prvek na pozici 3 je {0}", d);

            // generické pole 
            List<int> genpole = new List<int>();
            genpole.AddRange(new int[] { 54, 4, 2, 5, 6, 23, 2 });
            Console.Write(" Genericke pole:");
            foreach (int x in genpole)
                Console.Write(" {0}", x);
            Console.WriteLine();
            d = genpole[3];
            Console.WriteLine(" Prvek na pozici 3 je {0}", d);

            
            // Vyhledávání
            Console.WriteLine("Vyhledávání");
            Console.WriteLine(" prvek 6 {0} v poli na pozici {1}", (genpole.Contains(6) ? "je obsažen" : "není obsažen"), genpole.IndexOf(6));
            Console.WriteLine(" prvek 42 {0} v poli na pozici {1}", (genpole.Contains(42) ? "je obsažen" : "není obsažen"), genpole.IndexOf(42));


            // binární vyhledávání
            Console.WriteLine("Vyhledávání binární");
            genpole.Sort();
            Console.WriteLine(" prvek 4 je v poli na pozici {0}", genpole.BinarySearch(4));
            genpole.Clear();



            // operace s poli
            Osoba o1 = new Osoba("Luck", "Chopper", new DateTime(1942, 3, 20));
            Osoba o2 = new Osoba("Seymour", "Baker", new DateTime(1925, 12, 3));
            Osoba o3 = new Osoba("John", "Smith", new DateTime(1905, 8,9));
            Osoba o4 = new Osoba("Peter", "Carpenter", new DateTime(1931, 7,1));
            Osoba o5 = new Osoba("William", "Shoper", new DateTime(1928, 1,3));
            Osoba o6= new Osoba("Lawjoy", "Smoother", new DateTime(1907, 7,7));

            List<Osoba> opole1 = new List<Osoba>(new Osoba[] {o3,o4,o5});
            List<Osoba> opole2 = new List<Osoba>(new Osoba[] {o1,o2,o6});
            List<Osoba> opole3 = new List<Osoba>(new Osoba[] {o1,o1,o1,o2,o2,o1});
            List<Osoba> opole4 = new List<Osoba>(new Osoba[] { o1, o3, o5 });
            ArrayList list = new ArrayList(new object[] { "John", "Peter", 5, "Simon", 7 });

            // jedinecne prvky
            List<Osoba> opolea = new List<Osoba>(opole3.Distinct<Osoba>());
            // opacne pole
            List<Osoba> opoleb = new List<Osoba>(opole1.Reverse<Osoba>());
            // spojeni
            List<Osoba> opolec = new List<Osoba>(opole1.Concat(opole2));
            // mnozinovy rozdil
            List<Osoba> opoled = new List<Osoba>(opole3.Except(new List<Osoba>(new Osoba[] { o2 })));
            // prunik
            List<Osoba> opolee = new List<Osoba>(opole1.Intersect(opole4));
            // sjednocen
            List<Osoba> opolef = new List<Osoba>(opole1.Union(opole4));
            // zisk
            List<string> slist = new List<string>(list.OfType<string>());

            foreach (string o in slist)
                Console.WriteLine(o);

            Console.ReadKey();
        }
    }
}
