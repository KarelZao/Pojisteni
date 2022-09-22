using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojisteni
{
    /// <summary>
    /// Třída spravuje databazi osob
    /// </summary>
    internal class Databaze
    {
        /// <summary>
        /// Seznam osob
        /// </summary>
        private List<Osoba> osoby;

        /// <summary>
        /// Vytvoří novou instanci seznamu osob.
        /// </summary>
        public Databaze()
        {
            osoby = new List<Osoba>();
        }
        /// <summary>
        /// Přidá novou osobu do seznamu.
        /// </summary>
        /// <param name="jmeno">Jméno</param>
        /// <param name="prijmeni">Příjmení</param>
        /// /// <param name="vek">Věk</param>
        /// <param name="cislo">Telefonní číslo</param>
        public void PridejOsobu(string jmeno, string prijmeni, int vek, int cislo)
        {
            osoby.Add(new Osoba(jmeno, prijmeni, vek, cislo));
        }

        /// <summary>
        /// Najde osobu podle zadaného jména a příjmení.
        /// </summary>
        /// <param name="jmeno">Jméno</param>
        /// <param name="prijmeni">Příjmení</param>
        /// <returns></returns>
        public List<Osoba> NajdiOsobu(string jmeno, string prijmeni)
        {
            List<Osoba> vyhledany = new List<Osoba>();
            foreach (Osoba o in osoby)
            {
                if ((jmeno == o.Jmeno) && (prijmeni == o.Prijmeni))
                    vyhledany.Add(o);
            }
            return vyhledany;
        }
        /// <summary>
        /// Najde všechny osoby v seznamu.
        /// </summary>
        public List<Osoba> NajdiVsechny()
        {
            List<Osoba> vsechny = new List<Osoba>();
            foreach (Osoba o in osoby)
            {
                vsechny.Add(o);
            }
            return vsechny;
        }
    }
}
