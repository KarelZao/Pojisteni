using System;

namespace Pojisteni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instance třídy, která komunikuje s uživatelem
            VstupVystup vstupVystup = new VstupVystup();
            char volba = '0';
            // hlavní cyklus
            while (volba != '4')
            {
                vstupVystup.VypisUvodniObrazovku();
                Console.WriteLine();
                Console.WriteLine("Vyberte si akci:");
                Console.WriteLine("1 - Přidat nového pojištěného");
                Console.WriteLine("2 - Vypsat všechny pojištěné");
                Console.WriteLine("3 - Vyhledat pojištěného");
                Console.WriteLine("4 - Konec");
                volba = Console.ReadKey().KeyChar;
                Console.WriteLine();
                // vyhodnocení a reakce na volbu akce
                switch (volba)
                {
                    case '1':
                        vstupVystup.PridejOsobu();
                        break;
                    case '2':
                        vstupVystup.VypisVsechny();
                        break;
                    case '3':
                        vstupVystup.VyhledejOsobu();
                        break;
                    case '4':
                        Console.WriteLine("Konec");
                        break;
                    default:
                        Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Pokračujte libovolnou klávesou");
                Console.ReadKey();
            }
        }
    }
}
