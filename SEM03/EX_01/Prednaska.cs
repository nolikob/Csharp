using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_01
{
    /// <summary>
    /// Reprezentuje jednu prednasku na skole, ktera se kona v urcite datum.
    /// </summary>
    public class Prednaska : Vyuka
    {
        
        /// <summary>
        /// Nazev mista konani.
        /// </summary>
        

        /// <summary>
        /// Obsahuje URL, na kterem lze sledovat zivy prenos z prednasky.
        /// </summary>
        public string StreamUrl { get; set; }
        
        public Prednaska(string nazev, string anotace, DateTime datumKonani, Ucitel ucitel, string mistoKonani, string streamUrl) : base(nazev, anotace, datumKonani, ucitel, mistoKonani)
        {
            StreamUrl = streamUrl;
        }
    }
}
