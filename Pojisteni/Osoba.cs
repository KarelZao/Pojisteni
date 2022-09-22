using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojisteni
{
    /// <summary>
    /// Třída vytváří osobu
    /// </summary>
    internal class Osoba
    {
        /// <summary>
        /// Jméno osoby
        /// </summary>
        public string Jmeno { get; set; }
        /// <summary>
        /// Příjmení osoby
        /// </summary>
        public string Prijmeni { get; set; }
        /// <summary>
        /// Telefonní číslo osoby
        /// </summary>
        public int Cislo { get; set; }
        /// <summary>
        /// Věk osoby
        /// </summary>
        public int Vek { get; set; }

        /// <summary>
        /// Vytvoří novou instanci osoby.
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// /// <param name="vek"></param>
        /// <param name="cislo"></param>
        public Osoba (string jmeno, string prijmeni,int vek, int cislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            Cislo = cislo;
        }
        /// <summary>
        /// Vypíše osobu.
        /// </summary>
        /// <returns>Textová reprezentace osoby.</returns>
        public override string ToString()
        {
            return Jmeno + "    " + Prijmeni + "    " + Vek + "    " + Cislo;
        }
    }
}
