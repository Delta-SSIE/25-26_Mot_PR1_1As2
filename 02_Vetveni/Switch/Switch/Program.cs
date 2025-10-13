namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Switch - den v týdnu
            Console.WriteLine("Zadej mi pořadové číslo dne v týdnu.");
            int den = int.Parse(Console.ReadLine());

            //Switch vždy pracuje s hodnotou, případně více hodnotami
            //Ty se zapisují do závorky switch(hodnota)
            switch(den)
            {
                //case je jedna z možností, co může nastat
                case 1:
                    Console.WriteLine("Pondělí");
                    break; //break (ukončení stávajícího příkazu) --> vyskočí to z switche ven
                case 2:
                    Console.WriteLine("Úterý");
                    break;
                case 3:
                    Console.WriteLine("Středa");
                    break;
                case 4:
                    Console.WriteLine("Čtvrtek");
                    break;
                case 5:
                    Console.WriteLine("Pátek");
                    break;
            }

            //Porovnávací operátory ve switchy
            switch(den)
            {
                case 6:
                    Console.WriteLine("Je víkend");
                    break;
                case 7:
                    Console.WriteLine("Je víkend");
                    break;
                case < 0:
                    Console.WriteLine("Neplatný vstup");
                    break;
                case > 7:
                    Console.WriteLine("Neplatný vstup");
                    break;
                default: //spustí se pokud žádný case neodpovídá hodnotě
                    Console.WriteLine("Je den v týdnu");
                    break;
            }

            //switch --> posloupnost vyhodnocení
            /*
            switch(den)
            {
                case < 3:
                    Console.WriteLine("Číslo je menší než tři");
                    break;
                case 2:
                    Console.WriteLine("Číslo je dva!");
                    break;
                case < 0:
                    Console.WriteLine("Číslo je záporné!");
                    break;
            }
            */

            //Porovnávací operátory a logické operátory ve switchy
            switch (den)
            {
                //nahraje to hodnotu den do proměnné x
                //následně to porovnává a vyhodnocuje podmínku za slovem WHEN
                case int x when (x == 7 || x == 6): //x existuje pouze v rámci jednotlivého case
                    Console.WriteLine("Je víkend");
                    break;
                case int x when (x < 1 || x > 7):
                    Console.WriteLine("Neplatný vstup");
                    break;
                default: //spustí se pokud žádný case neodpovídá hodnotě
                    Console.WriteLine("Je den v týdnu");
                    break;
            }
          
        }
    }
}
