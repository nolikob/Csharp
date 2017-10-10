// EX005 Matematické operace
// ----------------------------
// výpis výsledků operace

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX005_MatematickeOperace
{
    class Program
    {
        static void Main(string[] args)
        {
            // matematicke operace ^ je umocneni a _ oznacuje dolni index

            // Pythagorova věta c^2 = a^2 + b^2
            double a = 5;
            double b = 6;
            double c = Math.Sqrt(a*a + b*b);
            Console.WriteLine("Vysledek je {0}", c);

            // sinová věta a / sin(alfa) = b / sin(beta)
            double alpha = 30;
            double beta = 60;
            b = 10;
            a = b * Math.Sin(alpha) / Math.Sin(beta);
            Console.WriteLine("Vysledek je {0}", a);

            // ověření, že y = log_a(x) => a^y = x
            double x = 4;
            a = 5;
            double y = Math.Log(x, a);
            double x2 = Math.Pow(a,y);
            Console.WriteLine("Vysledek je {0} = {1}", x, x2);

            // ověření, že x^4 = 81 => |x| = ctvrta_odmocnina_z(81)
            x = -3;
            y = Math.Pow(x,4);
            a = Math.Pow(y, (1.0 / 4.0));
            Console.WriteLine("Vysledek je {0} = {1}", a, Math.Abs(x));

            // rozdíl dělení
            int r = 5;
            a = 7 / 3;
            b = 7 % 3;
            c = 7 / 3.0;
            x = 7 / (r*1.0);
            Console.WriteLine("Vysledek je {0}; {1}; {2}; {3}", a, b, c, x);

            // zaokrouhlování
            a = Math.PI;
            b = Math.Round(a);
            c = Math.Ceiling(a);
            x = Math.Floor(c);
            Console.WriteLine("Vysledek je {0}; {1}; {2}; {3}", a, b, c, x);

            Console.ReadKey();
        }
    }
}
