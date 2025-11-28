namespace proc_troj_q
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int strana = 10;

            /* trojuhelník typu p
            for (int i = 0; i < strana; i++)
            {
                for (int j = 0; j < strana-i; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
            */
            for (int i = 0; i < strana; i++)
            {
                //Vnitřní cyklus pro výpis mezer
                //stane se tolikrát kolik je hodnota i
                //1. řádek  0krát; 2. řádek 1krát
                for (int n = 0; n < i; n++)
                {
                    Console.Write(' ');
                }
                //Vnitřní cyklus pro výpis #
                //stane se kolikrát kolik je strana - i
                //1. řádek strana - 0; 2. řádek strana - 1
                for (int j = 0; j < strana - i; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }

            //trojuhelník typu d

            for (int i = 0; i < strana; i++)
            {
                for (int j = 0; j < strana - i -1; j++)
                {
                    Console.Write(' ');
                }
                for (int n = 0; n <= i; n++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
        }
    }
}
