using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Pojisteni
{
    /// <summary>
    /// Třída pro komunikaci s uživatelem
    /// </summary>
    internal class VstupVystup
    {
        /// <summary>
        /// Databáze se seznamem osob
        /// </summary>
        private Databaze databaze;
        /// <summary>
        /// Vytvoří novou instanci databáze.
        /// </summary>
        public VstupVystup()
        {
            databaze = new Databaze();
        }
        /// <summary>
        /// Vyzve uživatele k přidání osoby a uloží ji do databáze.
        /// </summary>
        public void PridejOsobu()
        {
            string jmeno;
            string prijmeni;
            int cislo;
            int vek;
            Console.WriteLine("Zadejte jméno pojištěného:");
            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine()))
            {
                Console.WriteLine("Chybné zadání, zadejte jméno znovu:");
            }
            Console.WriteLine("Zadejte příjmení:");
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()))
            {
                Console.WriteLine("Chybné zadání, zadejte příjmení znovu:");
            }
            Console.WriteLine("Zadejte telefonní číslo:");
            while (!int.TryParse(Console.ReadLine(), out cislo))
                Console.WriteLine("Chybné zadání, zadejte číslo znovu: ");
            Console.WriteLine("Zadejte věk:");
            while (!int.TryParse(Console.ReadLine(), out vek))
                Console.WriteLine("Chybné zadání, zadejte věk znovu: ");
            
            databaze.PridejOsobu(jmeno, prijmeni, cislo, vek);
            Console.Write("Data byla uložena. ");
        }
        /// <summary>
        /// Vyhledá osobu podle jména a příjmení zadaného uživatelem.
        /// </summary>
        public void VyhledejOsobu()
        {
            string jmeno;
            string prijmeni;

            Console.WriteLine("Zadejte jméno pojištěného:");
            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine()))
            {
                Console.WriteLine("Chybné zadání, zadejte jméno znovu:");
            }
            Console.WriteLine("Zadejte příjmení:");
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()))
            {
                Console.WriteLine("Chybné zadání, zadejte příjmení znovu:");
            }
            List<Osoba> vyhledany = databaze.NajdiOsobu(jmeno, prijmeni);

            if (vyhledany.Count() > 0)
            {
                foreach (Osoba o in vyhledany)
                    Console.WriteLine(o);
            }
            else
                // Nenalezeno
                Console.WriteLine("Hledaná osoba není v databázi.");
        }
        /// <summary>
        /// Vyhledá a vypíše všechny osoby v databázi.
        /// </summary>
        public void VypisVsechny()
        {
            List<Osoba> vsechny = databaze.NajdiVsechny();
            if (vsechny.Count() > 0) 
            {
                foreach (Osoba o in vsechny)
                    Console.WriteLine(o);
            }
            else
                // Nenalezena žádná osoba
                Console.WriteLine("V databázi není žádný pojištěný.");
        }
        /// <summary>
        /// Vypíše úvodní obrazovku programu.
        /// </summary>
        public void VypisUvodniObrazovku()
        {
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Evidence pojištěných");
            Console.WriteLine("--------------------------");
            Console.WriteLine();
        }
    }
}
