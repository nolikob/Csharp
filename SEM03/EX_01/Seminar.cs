using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_01
{
    /// <summary>
    /// Reprezentuje jeden seminar na skole, ktery se kona v urcite datum.
    /// </summary>
    public class Seminar : Vyuka
    {
        

        /// <summary>
        /// Nazev mista konani.
        /// </summary>
        

        /// <summary>
        /// Pocet bonusovych bodu, ktere mohou pri aktivni ucasti studenti na 
        /// seminari ziskat, napr. resenim uloh.
        /// Pokud na seminari nelze ziskat bonusove body, pak je nastaveno 0.
        /// </summary>
        public int BonusoveBody { get; set; }
        

        public Seminar(string nazev, string anotace, DateTime datumKonani, Ucitel ucitel, string mistoKonani, int bonusoveBody) : base(nazev, anotace, datumKonani, ucitel, mistoKonani)
        {
            BonusoveBody = bonusoveBody;
        }
    }
}
