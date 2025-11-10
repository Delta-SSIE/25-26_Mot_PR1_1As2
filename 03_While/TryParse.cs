namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TryParse
            int cislo = 0;
            Console.WriteLine("Zadej číslo");
            string vstup = Console.ReadLine();

            // datovy_typ.TryParse(string, out výstupní proměnná)
            int.TryParse(vstup, out cislo);
            //vstup se to pokusí převést na int a pokud to LZE, tak se ten int rovnou uloží v proměnné cislo
            Console.WriteLine(cislo);

            //TryParse double
            double desCislo = 0;
            Console.WriteLine("Zadej desetinné číslo");
            string vstup2 = Console.ReadLine();
            double.TryParse(vstup2, out desCislo);
            Console.WriteLine(desCislo);

            //TryParse s parsováním vstupu od uživatele rovnou
            Console.WriteLine("Zadej mi číslo");
            int.TryParse(Console.ReadLine(), out cislo);
            Console.WriteLine(cislo);

            //TryParse jako součást podmínky
            Console.WriteLine("Zadej číslo");
            //Podmínka platí, pokud lze vstup parsovat na int
            if(int.TryParse(Console.ReadLine(),out cislo))
            {
                Console.WriteLine($"Ano, zadal jsi číslo a to je {cislo}");
            } else
            {
                Console.WriteLine("Ne, tohle není celé číslo!");
            }
            Console.WriteLine(cislo);

            //TryParse jako součást cyklu
            Console.WriteLine("Zadej mi číslo");
            double cislo2 = 0;
            //podmínka platí pokud NELZE vstup parsovat na double
            //! NOT
            while(!double.TryParse(Console.ReadLine(), out cislo2))
            {
                Console.WriteLine("Ne, zadal jsi něco jiného. Zadej mi číslo!");
            }
            Console.WriteLine(cislo2);
        }
    }
}
