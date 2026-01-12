namespace Uvod_metody
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pozdrav(); //volání metody Pozdrav - ta se automaticky vykoná

            /*
            for (int i = 0; i < 100; i++)
            {
                Pozdrav();
            }
            */

            PozdravSpec("Jan", 38); //volání metody PozdravSpec s dvěma argumenty

            Console.WriteLine("Jak se jmenuješ?");
            string jmeno = Console.ReadLine();
            PozdravSpec(jmeno, 50);

            Console.WriteLine("Zadej mi číslo A");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej mi číslo B");
            int b = int.Parse(Console.ReadLine());

            int soucet = Soucet(a, b); //návratová hodnota se uloží do proměnné soucet
            Console.WriteLine(soucet);

            Console.WriteLine(Soucet(a,b));
            Console.WriteLine(Soucet(30, 20));

            //Praktický příklad - TryParse
            int cisloA = BezpecneNacti();
            int cisloB = BezpecneNacti();
            int cisloC = BezpecneNacti();


        }

        //Metoda Pozdrav()
        //Nemá žádný parametry, ten by byl uveden v ()
        //je VOID (neboli prázdná) --> nebude vracet žádnou hodnotu
        //je static existuje uvnitřní vnitřní třídy Program
        static void Pozdrav()
        {
            Console.WriteLine("Hello, World!");
        }

        //Metoda PozdravSpec()
        //Metoda má dva parametry, jeden string 'name' a druhý int 'age'
        //Tyto parametry musíme naplnit ARGUMENTY, když metodu voláme!
        static void PozdravSpec(string name, int age)
        {
            Console.WriteLine($"Hello, {name} {age}!");
        }

        //Metoda Soucet()
        //2 parametry - int x a y
        //vrací hodnotu v int datovém typu
        static int Soucet(int x, int y)
        {
            //Return říká, co se má vrátit
            //"Vždy" se vrací jedna hodnota
            return x + y;
        }


        static int BezpecneNacti()
        {
            Console.WriteLine("Zadej mi číslo");
            int cislo = 0;
            while(!int.TryParse(Console.ReadLine(),out cislo))
            {
                Console.WriteLine("Zadej opravdu číslo");
            }
            return cislo;
        }
    }
}
