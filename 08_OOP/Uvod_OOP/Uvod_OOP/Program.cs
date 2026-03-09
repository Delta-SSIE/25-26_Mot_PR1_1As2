namespace Uvod_OOP
{
    internal class Jablko
    {
        public double hmotnost;
        public string barva;
        public string chut;
        public string stav;
        public string zemePuvodu;

        public void Snist()
        {
            Console.WriteLine("Mňam");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vytváření objektů (instance třídy)
            Ovoce jablko = new Ovoce();
            Ovoce mandarinka = new Ovoce();

            //Manipulaci s položkami (tečková syntaxe)
            jablko.nazev = "Jablko";
            mandarinka.nazev = "Mandarinka";
            
            jablko.hmotnost = 20.5;
            mandarinka.hmotnost = 15.3;

            jablko.hmotnost += 1.5;

            Console.WriteLine($"Hmotnost {jablko.nazev} je {jablko.hmotnost} gramů.");
            Console.WriteLine($"Hmotnost {mandarinka.nazev} je {mandarinka.hmotnost} gramů.");

            //Volání metod objektů
            Console.WriteLine(jablko.stav);

            jablko.Snist();
            Console.WriteLine(jablko.stav);
            mandarinka.Snist();
            Console.WriteLine("Moje " + jablko.nazev + " je " + jablko.GetChut());
            jablko.SetChut("sladoucke");
            Console.WriteLine("Moje " + jablko.nazev + " je " + jablko.GetChut());



        }
    }
}
