namespace Uvod_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For cyklus
            for(int i = 0; i < 5; i++)
            //int i = 0 se nastaví při začátku cyklu (vykoná se pouze jednou)
            // i < 5 podmínka se vykoná vždy před vstupem do těla cyklu
            //i++ se vykoná vždy po konci průchodu tělem cyklu
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //For cyklus - výpis čísel 1 až 5
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //For cyklus - čísla od 10 do 0
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            //For cyklus
            //uživatel zadá x a program vypíše všechna čísla od x do 100
            int x = 0;
            Console.WriteLine("zadej mi číslo x:");
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Zadej opravdu číslo");
            }

            for (int i = x; i < 100; i++)
            {
                Console.WriteLine(i);
            }

            //For cyklus
            //uživatel bude postupně zadávat 10 čísel
            //na konci programu se vypíše součet těchto čísel
            //POKUD! Uživatel zadá během zadávání 0, či záporné číslo.
            //Zadávání okamžitě skončí a vypíše se součet z čísel dosud zadaných.

            int soucet = 0;
            for (int i = 1; i < 11; i++)
            {
                int cislo = 0;
                Console.WriteLine($"Zadej mi {i}. kladné číslo (pro ukončení 0, či zap. číslo)");
                while(!int.TryParse(Console.ReadLine(), out cislo))
                {
                    Console.WriteLine("Zadej číslo");
                }
                if(cislo < 1)
                {
                    break;
                    // i = 100;
                }
                soucet += cislo;
            }
            Console.WriteLine($"Součet čísel je {soucet}");

            //For cyklus
            //Průměr z X hodů 6stěnnou kostkou
            //X zadá uživatel na začátku
            //Na konci se vypíše "Z X hodů je průměr Y"
            Random kostka = new Random();
            double pocet_hodu = 0;
            double soucet_hodu = 0;

            Console.WriteLine("zadej mi počet hodů");
            while(!double.TryParse(Console.ReadLine(),out pocet_hodu))
            {
                Console.WriteLine("Zadej přirozené číslo");
            }

            //for(int i = pocet_hodu; i > 0; i--)
            for (int i = 0; i < pocet_hodu; i++)
            {
                soucet_hodu += kostka.Next(1, 7);
            }

            Console.WriteLine($"Z {pocet_hodu} je průměr {soucet_hodu/pocet_hodu}");

        }
    }
}
