namespace Malovani_V_Konzoli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Čára v konzoli pomocí # (# # # #)

            for (int i = 0; i < 20; i++)
            {
                if(i % 2 == 0)
                {
                    Console.Write('#');
                } else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();

            //Vnější a vnitřní cyklus
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.Write('#');
                }
                for (int n = 0; n < 3; n++)
                {
                    Console.Write(' ');
                }
                
            }

            //2D 
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
        }
    }
}
