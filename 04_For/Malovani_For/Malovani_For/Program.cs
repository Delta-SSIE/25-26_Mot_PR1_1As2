namespace Malovani_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2D čtverec

            //Vnější cyklus řeší počet řádků
            for (int i = 0; i < 5; i++)
            {
                //Vnitřní cyklus naopak počet sloupců
                for (int j = 0; j < 5; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //2D obdelník

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }

            //2D obdelník, který bude střídat symboly X a #
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if(j % 2 == 0)
                    {
                        Console.Write('#');
                    } else
                    {
                        Console.Write('X');
                    }
                    
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            //2D obdelník, kde do poloviny sloupců jsou # a od poloviny X

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write('#');
                }
                for (int n = 0; n < 10; n++)
                {
                    Console.Write('X');
                }
                Console.WriteLine();
            }
        }
    }
}
