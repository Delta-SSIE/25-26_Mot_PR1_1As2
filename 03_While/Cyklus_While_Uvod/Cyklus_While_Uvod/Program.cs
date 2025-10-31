namespace Cyklus_While_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program, který zvyšuje hodnotu čísla o 1
            /*
            int cislo = 0;
            Console.WriteLine(cislo);
            cislo++;
            Console.WriteLine(cislo);
            cislo++;
            Console.WriteLine(cislo);
            cislo++;
            */

            //Program zvyšující hodnotu čísla o 1 s použitím cyklu
            int cislo = 0;

            //cyklus WHILE´- dokud
            //Cyklus se opakuje, dokud je splněna podmínka
            while(cislo < 11)
            {
                Console.WriteLine(cislo);
                cislo++;
            }

            /* Nekonečný cyklus
            while(true)
            {
                Console.WriteLine(cislo);
                cislo++;
            }
            */

            //Hádání čísla pomocí cyklu
            Random gen = new Random();
            int nah_cislo = gen.Next(1, 6);
            Console.WriteLine("Zadej mi číslo, které si myšlíš, že se vygenerovalo (1-5)");
            int had_cislo = int.Parse(Console.ReadLine());

            while(had_cislo != nah_cislo)
            {
                Console.WriteLine("To není to číslo! Hádej znovu!");
                had_cislo = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Gratuluji, uhádl si číslo! Bylo to {nah_cislo}");

            //Hádání čísla pomocí cyklu – Do WHILE
            nah_cislo = gen.Next(1, 6);
            
            int had_cislo_v2 = 0;

            //Do while
            //do oznčuje vše, co je tělo cyklu - to se alespoň 1 vykoná
            do
            {
                Console.WriteLine("Hádej číslo 1-5");
                had_cislo_v2 = int.Parse(Console.ReadLine());
            } while (had_cislo_v2 != nah_cislo);
            //podmínka na konci se ověřuje, až po provedení kódu v těle cyklu
            //podmínka funguje stejně jako u WHILE - cyklus se opakuje dokud platí

            Console.WriteLine($"Gratuluji, uhádl si číslo! Bylo to {nah_cislo}");

            //Break a continue

            //Break pro ukončení cyklu
            while (true)
            {
                nah_cislo = gen.Next(0, 11);
                Console.WriteLine(nah_cislo);
                if(nah_cislo == 10)
                {
                    //break automaticky vyskočí z cyklu ven
                    break;
                }

            }
            Console.WriteLine("--------------");
            //Continue
            while(true)
            {
                nah_cislo = gen.Next(0, 11);
                if (nah_cislo < 5)
                {
                    //break automaticky vyskočí z cyklu ven
                    continue;
                }
                Console.WriteLine(nah_cislo);
                if (nah_cislo == 10)
                {
                    //break automaticky vyskočí z cyklu ven
                    break;
                }
            }

        }
    }
}
