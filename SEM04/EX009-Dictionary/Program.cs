using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX009_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict[5] = "Peter";
            dict[7] = "John";
            dict[3] = "Simon";
            dict[12] = "Paul";
            dict[2] = "Peter";
            dict[3] = "Howard";
            dict[4] = "Candle";
            dict[9] = "Meuvee";

            Console.WriteLine(dict.ContainsKey(5));
            Console.WriteLine(dict.ContainsValue("Peter"));

            Console.WriteLine(dict[3]);
            Console.WriteLine(dict.ContainsValue("Peter"));

        }
    }
}
