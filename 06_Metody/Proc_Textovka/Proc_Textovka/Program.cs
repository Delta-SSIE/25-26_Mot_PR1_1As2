namespace Proc_Textovka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mistnosti = new string[]
           {
                    "Vstupní hala",
                    "Knihovna",
                    "Sklep",
                    "Pokladnice",
                    "Tajná komnata"
           };

            int[] predmety = new int[mistnosti.Length];
            Random gen = new Random();
            int indexklic = gen.Next(0, predmety.Length);
            int indexdvere = gen.Next(0, predmety.Length);
            while(indexklic == indexdvere)
            {
                indexdvere = gen.Next(0, predmety.Length);
            }
            for (int i = 0; i < predmety.Length; i++)
            {
                switch(i)
                {
                    case int x when x == indexdvere:
                        predmety[i] = 2; //dveře
                        break;
                    case int x when x == indexklic:
                        predmety[i] = 1; //klič
                        break;
                    default:
                        predmety[i] = 0;
                        break;
                }
            }

            int indexHrac = 0;
            bool klic = false;

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Hráč je v místnosti {mistnosti[indexHrac]}");
                VypisObsah(predmety, indexHrac);
                Console.WriteLine("Pokud chceš jít dopředu zadej \"vpřed\", pokud dozadu zadej  \"zpět\". Pokud chceš interagovat s předměty v místnosti, tak zadej \"interagovat\"");
                string volba = Console.ReadLine();
                if(volba != "interagovat")
                {
                    indexHrac = Pohyb(volba, indexHrac, mistnosti);
                } else
                {
                    if (predmety[indexHrac] == 1)
                    {
                        klic = true;
                        predmety[indexHrac] = 0;
                        Console.WriteLine("Sebral jsi klíč!");
                        Console.ReadKey();
                    } else if (predmety[indexHrac] == 2)
                    {
                        if(klic)
                        {
                            Console.WriteLine("Výhra!");
                            break;
                        } else
                        {
                            Console.WriteLine("Nemáš klíč!");
                            Console.ReadKey();
                        }
                    }
                }
                

            }
        }

        static int Pohyb(string v, int hrac, string[] mis)
        {
            if(mis.Length-1 == hrac && v == "vpřed")
            {
                return hrac;
            } else if(hrac == 0 && v == "zpět")
            {
                return hrac;
            }

            if(v == "vpřed")
            {
                return hrac + 1;
            }
            if (v == "zpět")
            {
                return hrac - 1;
            }
            return hrac;

        }
        static void VypisObsah(int[] pred, int pozice)
        {
            switch(pozice)
            {
                case int p when pred[p] == 1:
                    Console.WriteLine("V místnosti je klíč.");
                    break;
                case int p when pred[p] == 2:
                    Console.WriteLine("V místnosti jsou dveře.");
                    break;
                default:
                    Console.WriteLine("Místnost je prázdná");
                    break;
            }

        }
    }
}
