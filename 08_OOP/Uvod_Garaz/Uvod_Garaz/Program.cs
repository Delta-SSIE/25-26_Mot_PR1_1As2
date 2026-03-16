using System.Linq.Expressions;

namespace Uvod_Garaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklarace objektu Auto
            Auto moje_auto = new Auto();

            //Vložení hodnot na atributy objektu
            moje_auto.SPZ = "XXXX";
            moje_auto.pocetKol = 4;

            //Zavolání metody u objektu
            moje_auto.PredstavSe();

            //Inicializace objektu s hodnotami na vlastnostech
            Auto sousedovo_auto = new Auto
            {
                SPZ = "YYY",
                pocetKol = 4
            };

            //Úprava hodnoty vlastnosti
            sousedovo_auto.pocetKol--;
            sousedovo_auto.pocetKol--;

            sousedovo_auto.PredstavSe();
            
            //Vlastnost jako kolekce
            moje_auto.pasazeri = ["Kubík", "Patrik", "Filip", "Štěpán",];
            sousedovo_auto.pasazeri = ["Tonda", "Tomáš", "Daniel"];

            Console.WriteLine(moje_auto.pasazeri[0]);
            moje_auto.VypisPasazery();
            sousedovo_auto.VypisPasazery();

            //Kolekce objektů
            //Inicilizace pole s dvěma hodnotama
            Auto[] garaz = { moje_auto, sousedovo_auto };

            //Výpis všech pasažerů ve všech autech, které jsou v garáži (bez VypisPasazery())
            for (int i = 0; i < garaz.Length; i++) //délka pole garaz
            {
                Console.WriteLine("Auto číslo " + (i + 1));
                for (int j = 0; j < garaz[i].pasazeri.Length; j++) //delka pole pasažéři na prvku v garaži na indexu i
                {
                    Console.WriteLine(garaz[i].pasazeri[j]);
                }
                Console.WriteLine("------------------------------");
            }

            //Rozšíření garáže
            Auto sestrino_auto = new Auto
            {
                SPZ = "CCC",
                pocetKol = 4,
                pasazeri = ["Kamila"]
            };

            Array.Resize(ref garaz, garaz.Length + 1);
            garaz[garaz.Length - 1] = sestrino_auto;

            //Znova výpis
            for (int i = 0; i < garaz.Length; i++) //délka pole garaz
            {
                Console.WriteLine("Auto číslo " + (i + 1));
                for (int j = 0; j < garaz[i].pasazeri.Length; j++) //delka pole pasažéři na prvku v garaži na indexu i
                {
                    Console.WriteLine(garaz[i].pasazeri[j]);
                }
                Console.WriteLine("------------------------------");
            }



        }
    }
}
