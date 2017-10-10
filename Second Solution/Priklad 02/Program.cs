using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priklad_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pro zadaný intervalu <a,b> kde a,b  vypiště součet násobků Pi (přibližné násobky).
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double sum = 0;
            //while (sum < b)
            //{
            //    sum += pi;
            //    if (sum < b)
            //    {
            //        celkem += sum;
            //    }

            //}
            double nejnizsiNasobekIntervalu = Math.Ceiling(nejnizsiNasobekIntervalu = a / Math.PI) * Math.PI;
            double nasobekPI = nejnizsiNasobekIntervalu;
            while (nasobekPI <= b)
            {
                sum += nasobekPI;
                nasobekPI += Math.PI;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
