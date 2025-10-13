namespace Generace_nah_cisel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //generace náhodných čísel pomocí class Random
            //Random nazev = new Random();
            //nazev může být cokoliv, co budete chtít
            Random generator = new Random();

            //kdykoliv potřebuji vytvořit náhodné číslo použiju generator
            //generator.Next(spodní hranice (včetně), horní hranice (bez))
            int nah_cislo = generator.Next(0, 2); //0–1
            Console.WriteLine(nah_cislo);

            Console.WriteLine(generator.Next(1,7)); //1-6

            Console.WriteLine(generator.Next()); //náhodné číslo
            Console.WriteLine(generator.NextDouble()); //double v rozmezí 0 až 1
        }
    }
}
