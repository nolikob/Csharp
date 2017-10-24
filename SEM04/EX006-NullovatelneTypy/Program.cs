using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX006_NullovatelneTypy
{
    class Program
    {
        public struct Human
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public Human Value
            {
                get
                {
                    return this;
                }
                set
                {
                    Id = value.Id;
                    Name = value.Name;
                }
            }
        }

        public static int?[] ZiskejVysleky()
        {
            int?[] res = {8,null, 23, 2, 12, 6, null, 23};

            return res;
        }

        static void Main(string[] args)
        {



            // získáme výsledky nějaké operace, přičemž některé výsledky nemusí být definovány - ne nutně numerický důvod
            Console.WriteLine("Pole s null hodnotami");
            int?[] vysledky = ZiskejVysleky();
            int pos = 0;

            foreach (int? x in vysledky)
            {
                if (x != null)
                    Console.WriteLine(" {0}. vysledek je = {1}", pos++, x);
                else
                    Console.WriteLine(" {0}. vysledek není definován",pos);
            }


            // převod na normální pole integerů 
            Console.WriteLine("Pole bez null");
            for (int i = 0; i < vysledky.Length; i++)
                vysledky[i] = vysledky[i] ?? -1;
            pos = 0;
            foreach (int? x in vysledky)
            {
                Console.WriteLine(" {0}. vysledek je = {1}", pos++, x);
            }
            Console.ReadKey();



            // hodnotave typy
            Human original = new Human();
            original.Id = 5;
            original.Name = "Peter";

            // vytvoření nullovatelné kopie
            Human? nullableInstance = original;
            Human copy = nullableInstance.Value;

            // změna originálu
            original.Id = 2;
            original.Name = "John";

            // výpis obojího
            Console.WriteLine("{0} {1}", copy.Id, copy.Name);
            Console.WriteLine("{0} {1}", original.Id, original.Name);
        }
    }
}