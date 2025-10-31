namespace Soucet_zadanych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadávej čísla a já je budu sčítat. Vkládání ukončíš vložením nuly");
            int soucet = 0;
            int zad_cislo = 0;

            do
            {
                Console.WriteLine("Zadej číslo");
                zad_cislo = int.Parse(Console.ReadLine());
                if (zad_cislo != 0)
                {
                    soucet += zad_cislo;
                    Console.WriteLine($"Aktuální součet je {soucet}");
                }
            } while (zad_cislo != 0);
        }
    }
}
