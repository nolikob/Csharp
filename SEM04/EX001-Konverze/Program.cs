// EX001 Konverze  
// ----------------------------
// Konverze datových typů

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX001_Konverze
{
    public class Ovoce { }

    public class Jablko : Ovoce { }

    public class Hruska : Ovoce { }

    class Program
    {
        static void Main(string[] args)
        {
            // konverze int -> double
            int i = 3;
            double d = (double)i;
            Console.WriteLine("i = {0} -> d = {1} ",i,d);

            // konverze double -> int
            d = 3.2;
            i = (int)d;
            Console.WriteLine("d = {0} -> i = {1} ", d, i);

            // konverze int -> byte
            i = 3;
            //i = 256;
            byte b = (byte)i;
            Console.WriteLine("i = {0} -> b = {1} ", i, b);

            // použití metod
            i = System.Convert.ToInt32(b);
            Console.WriteLine("b = {0} -> i = {1} ", b, i);

            // implicitní konverze
            Jablko j = new Jablko();
            Ovoce o = (Ovoce)j;
            //Ovoce o = j;

            // zahlásí chybu až při běhu
            //Hruska h = (Hruska) o;

            

            Console.ReadKey();
        }
    }
}
