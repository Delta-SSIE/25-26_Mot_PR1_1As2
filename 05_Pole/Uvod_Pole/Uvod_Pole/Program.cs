namespace Uvod_Pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklarace pole

            int[] pole_cisel; //nevyplatí se deklarovat pole bez velikosti, či hodnot!

            //Incializace pole

            //pole jmena má délku: 5 (a stejný počet zadaných hodnot)
            string[] jmena = { "Jan", "Ivana", "Jakub", "Karel", "Lukáš" };
            //pole cisel o délce: 5 (bez hodnot)
            int[] cisla = new int[5];

            //Pole vždy musí mít danou délku!

            //Výpis prvků z pole
            Console.WriteLine(jmena[0]);
            Console.WriteLine(jmena[4]);
            //nazev_pole[index]

            //poslední prvek z pole
            Console.WriteLine(jmena[jmena.Length-1]);
            //Délka pole jako u délky stringu
            Console.WriteLine(jmena.Length);

            //přepsání hodnoty Jan v poli jmena na hodnotu Kamil
            //Jan je na indexu 0
            jmena[0] = "Kamil";
            Console.WriteLine(jmena[0]);

            //Přepsání hodnoty v poli cisla na 0. indexu na 5
            cisla[0] = 5;
            Console.WriteLine(cisla[0]);

            //Projít pole jmena a vypsat je do jednoho řádku
            
            /*
            Console.Write(jmena[0]);
            Console.Write(jmena[1]);
            */

            for (int i = 0; i < jmena.Length; i++)
            {
                //i začíná od 0 a zvyšuje se s každým průchodem cyklu až na 4
                //délka je 5
                Console.Write(jmena[i] + " ");
            }
            Console.WriteLine();

            //Přepis všech hodnot v poli cisla na hodnotu 100
            for (int i = 0; i < cisla.Length; i++)
            {
                cisla[i] = 100;
            }
            for (int i = 0; i < cisla.Length; i++)
            {
                Console.Write(cisla[i]+ " ");
            }
            Console.WriteLine();

            //Výpis výdajů pro jednotlivé měsíce roku
            int[] vydaje_2025 = new int[12];
            Random gen = new Random();

            for (int i = 0; i < vydaje_2025.Length; i++)
            {
                vydaje_2025[i] = gen.Next(-25000, 1000000);
            }

            for (int i = 0; i < vydaje_2025.Length; i++)
            {
                Console.WriteLine($"Za měsíc {i+1} jsou vydaje firmy {vydaje_2025[i]}");
            }

            //Foreach
            //Dobré pro výpis prvků z pole
            //Nelze v rámci foreache přepisovat hodnoty v poli!!!

            foreach (int vydaj in vydaje_2025)
                //pro každý prvek daného datového typu z kolekce
            {
                //do proměnné vydaj, postupně nahrává prvky z pole vydaje_2025
                Console.WriteLine(vydaj);
                //vydaje = 2000; NELZE!
            }

        }
    }
}
