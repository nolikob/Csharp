using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX005_ParametryMetod
{
    class Program
    {
        /// <summary>
        /// Metoda na sečtení polynomu ve formě a_k * x^k + a_(k-1) * x^(k-1) + ... + a_1 * x + a_0, kde proměnná x je dána parametrem
        /// stejně jako konstanty a_i (pozn. znak _ značí index a znak ^ nocninu).
        /// </summary>
        /// <param name="x">Proměnná polynomu</param>
        /// <param name="konstanty">Proměnný počet konstant udávající i řád polynomu</param>
        /// <returns>Součet polynomu</returns>
        public static double SectiPolynom(double x, params double[] konstanty)
        {
            double sum = 0.0;
            int exp = konstanty.Length - 1;

            foreach (double a in konstanty)
            {
                sum += a * Math.Pow(x, exp--);
            }

            return sum;
        }

        public static int TestovaciMetoda(int parametr)
        {
            parametr += 10;
            return parametr;
        }
        
        public static int TestovaciMetoda2(ref int parametr)
        {
            parametr += 10;
            return parametr;
        }

        public static int TestovaciMetoda3(out int parametr)
        {
            // je nutné přistupovat k ní jako k neinicializované proměnné
            parametr = 10;
            return parametr;
        }

        static void Main(string[] args)
        {
            // Proměnný počet parametrů
            Console.WriteLine(" Pro x = 2 je 3*x^2 + 4*x + 3 = {0}", SectiPolynom(2, 3, 4, 3));
            Console.WriteLine(" Pro x = 1,345 je 0,5*x^4 - 10*x^3 + 234,56*x + 30,8 = {0}", SectiPolynom(1.345, -10, 0, 234,56, 30,8));

            
            // modifikátory ref a out
            int p = 8;
            int r = TestovaciMetoda(p);
            Console.WriteLine("\nTestování bez ref i out:");
            Console.WriteLine("{0} {1}", p, r);
            // modifikátor ref - nutná inicializace
            int e = 3;
            int w = TestovaciMetoda2(ref e);
            Console.WriteLine("\nTestování s ref:");
            Console.WriteLine("{0} {1}", e, w);
            // modifikátor out - není nutná inicializace
            int t;
            int s = TestovaciMetoda3(out t);
            Console.WriteLine("\nTestování s out:");
            Console.WriteLine("{0} {1}", t, s);

            Console.ReadKey();
        }
    }
}
