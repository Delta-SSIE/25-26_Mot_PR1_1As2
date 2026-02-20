using System.Runtime.InteropServices;

namespace Lode
{
    internal class Program
    {
        //počet lodí viditelný pro všechny metody ve třídě Program
        static int pocet_lodi = 4;
        static void Main(string[] args)
        {
            // 'V' - voda; 'L' - lod; 'Z' - zasažená lod; 'M' - zásah mimo
            
            //velikost pole
            int velikost = 8;
            
            char[,] hrac = new char[velikost, velikost];
            char[,] hrac_strelba = new char[velikost, velikost];
            char[,] souper = new char[velikost, velikost];

            hrac = NaplnVodou(hrac);
            hrac_strelba = NaplnVodou(hrac_strelba);
            souper = NaplnVodou(souper);

            VypisPole(hrac);

            hrac = VlozLode(pocet_lodi, hrac, false);
            souper = VlozLode(pocet_lodi, souper, true);
            VypisPole(hrac);
            VypisPole(souper);

        }

        static char[,] VlozLode(int pocet, char[,] pole, bool pc)
        {
            Random gen = new Random();
            for (int i = 0; i < pocet; i++)
            {
                int y = 0;
                int x = 0;
                do
                {
                    if(pc)
                    {
                        y = gen.Next(0, pole.GetLength(0));
                        x = gen.Next(0, pole.GetLength(1));
                    } else
                    {
                        Console.WriteLine("Na jakou souřadnici Y chceš vložit loď");
                        y = BezpecVstup();
                        Console.WriteLine("Na jakou souřadnici X chceš vložit loď");
                        x = BezpecVstup();
                    }
            
                    if(!MimoPole(pole,x,y))
                    {
                        Console.WriteLine("Souřadnice jsou mimo hrací pole");
                        continue;
                    }
                } while (!JeVolne(pole, x, y));
                pole[y, x] = 'L';
            }
            return pole;

        }

        static bool MimoPole(char[,] mapa, int x, int y)
        { 
            if((y > mapa.GetLength(0) || y < 0) || (x > mapa.GetLength(1) || x < 0))
            {
                return false;
            }
            return true;
        }

        static bool JeVolne(char[,] mapa, int x, int y)
        {
            if (mapa[y,x] == 'V')
            {
                return true;
            }
            return false;
        }

        static int BezpecVstup()
        {
            int cislo = 0;
            while(!int.TryParse(Console.ReadLine(),out cislo))
            {
                Console.WriteLine("Napiš číslo!");
            }
            return cislo;
        }
        static void VypisPole(char[,] mapa)
        {
            //Pokud bude více sloupců a řádku než 10, rozbije se formátování //ToDo
            //Výpis souřadnic pro sloupce
            Console.Write(" ");
            for (int i = 0; i < mapa.GetLength(1); i++)
            {
                Console.Write(i); //pokud chceme začínat 1 tak (i+1)
            }
            Console.WriteLine();

            for (int i = 0; i < mapa.GetLength(0); i++)
            {
                //přidá souřadnici řádku na jeho začátek
                Console.Write(i); //pokud chceme začínat 1 tak (i+1)
                for (int j = 0; j < mapa.GetLength(1); j++)
                {
                                        // 'V' - voda; 'L' - lod; 'Z' - zasažená lod; 'M' - zásah mimo
                    switch(mapa[i,j])
                    {
                        case 'V':
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(' ');
                            break;
                        case 'L':
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(' ');
                            break;
                        case 'Z':
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(' ');
                            break;
                        case 'M':
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(' ');
                            break;
                    }
                    
                }
                Console.ResetColor();
                Console.WriteLine();
            }
       
        }
        static char[,] NaplnVodou(char[,] pole)
        {
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    pole[i, j] = 'V';
                }
            }
            return pole;
        }
    }
}
