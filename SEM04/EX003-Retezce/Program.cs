// EX003 Práce s řetězci
// ----------------------------
// Rozdělování split a regulární výrazy

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace EX003_Retezce
{
    class Program
    {
        static void Main(string[] args)
        {

            // použití split
            string s = " Kudy vede cesta,tudy?";
            char[] sep = {' ',',','?'};
            string[] arr = s.Trim().Split(sep);

            foreach (string x in arr)
            {
                Console.Write("'{0}' ", x);
            }
            Console.WriteLine();



            // regulární výrazy - Match
            string[] values = { "2006.05.06", "31-10-2006", "2006-10-31", "1900/1/1", "1900/01/01" };
            string pattern = @"^(19|20)\d\d[-/.](0[1-9]|1[012])[-/.](0[1-9]|[12][0-9]|3[01])$";
            foreach (string value in values)
            {
                if (Regex.IsMatch(value, pattern))
                    Console.WriteLine("  {0} je validní datum.", value);
                else
                    Console.WriteLine("  {0}: Chyba", value);
            }



            // regulární výrazy - detailnější průchod 
            // lze vytvářet skupiny (závorkami) a ty posléze vytahovat z výsledků regulárního výrazu
            string svalue = "Chleba 20 Kc, Vejce 30 Kc, Dzus 30 Kc";
            pattern = @"\b(\d+?) (Kc)\b";
            foreach (Match match in Regex.Matches(svalue, pattern,RegexOptions.IgnoreCase))
                Console.WriteLine("{0} pozice = {1} Mnozstvi = {2} mena = {3}", match.Value, match.Index, match.Groups[1].Value, match.Groups[2].Value);


            // Replace - výměna určitých částí
            svalue = "Chleba 20 Kc, Vejce 30 Kc, Dzus 30 Kc";
            pattern = "(Kc)";
            string newstring = Regex.Replace(svalue, pattern, "$");
            Console.WriteLine("  {0}", newstring);


            // zpracování specifickych znaku
            //pattern = "znaků .*?";
            pattern = "znaků " + Regex.Escape(".*?");
            string input = "Toto je zkusebni text na zpracování znaků .*? dohromady .";
            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
                Console.WriteLine("   {0}", match.Value);  

            Console.ReadKey();
        }
    }
}
