namespace For_cyklus_a_podminka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] prodeje = new int[10000000];
            Random gen = new Random();

            for (int i = 0; i < prodeje.Length; i++)
            {
                prodeje[i] = gen.Next(0, 1000000);
            }

            //Kolik z čísel v poli prodeji je v rozsahu 0 až 10
            //A o která čísla se jedná

            for (int i = 0; i < prodeje.Length; i++)
            {
                if (prodeje[i] >= 0 && prodeje[i] <= 10)
                {
                    Console.Write(prodeje[i] + " ");
                }
            }
            Console.WriteLine();

            //Kolik je to ale 0, 1, 2, atd.?
            int[] vysledky = new int[11];
            
            for (int i = 0; i < prodeje.Length; i++)
            {
                if (prodeje[i] >= 0 && prodeje[i] <= 10)
                {
                    vysledky[prodeje[i]]++;
                }
            }

            for (int i = 0; i < vysledky.Length; i++)
            {
                Console.WriteLine($"Počet {i} je {vysledky[i]}");
            }
        }
    }
}
