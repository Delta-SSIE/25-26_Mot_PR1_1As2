namespace datove_typy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //deklarace desetinné číslo
            float myFloat = 5.123456789f; //pro rozdělení tečka místo čárky (konzole vypisuje čárku)
            //při zadaní většího množství čísel než je schopen float pobrat se zaokrouhlí
            //potřeba napsat za desetinné místo "f"
            double myDouble = 12.12;
            Console.WriteLine(myFloat);
            Console.WriteLine(myDouble);

            //Bool
            bool hodnota = true;
            hodnota = false;
            //nezná jiné hodnoty než true, nebo false

            //Char
            char znak = 'h'; //jednoduché závorky, ne dvojité!
            char znak2 = 'o'; // jednoduché uvozovky - vedle ! s Shiftem, jinak píše ¨
            Console.WriteLine(znak+""+znak2);
            //vstup Readkey pro vložení znaku
            Console.WriteLine("Napiš mi znak");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine(input);


            //Program sčítání dvou čísel
            string x;
            string y;
            Console.WriteLine("Zadej mi první číslo");
            x = Console.ReadLine();
            //přes Convert:
            int cisloX = Convert.ToInt32(x);
            //převede hodnotu string proměnné x na Int32 (neboli int)
            //hodnota se pak uloží do proměnné cisloX
            Console.WriteLine("Zadej mi druhé číslo");
            y = Console.ReadLine();
            //přes Parse:
            int cisloY = int.Parse(y);
            //parsuje hodnotu y na int
            //hodnot ase uloží do proměnné cisloY
            Console.WriteLine($"Součet je {cisloX+cisloY}");


            //Implicit casting
            char myChar = 'z';
            long myLong = myChar;
            Console.WriteLine(myLong);
            //Explicit casting
            myChar = (char) myLong; //přidá se zavorka s datovým typem
            Console.WriteLine(myChar);

            //Sčítání 2.0 bez string proměnné navíc
            Console.WriteLine("Napiš mi první číslo");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Napiš mi druhé číslo");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Součet čísel je {0}",a+b);

        }
    }
}
