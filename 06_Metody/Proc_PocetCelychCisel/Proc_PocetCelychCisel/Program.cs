namespace Proc_PocetCelychCisel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] cisla = { 7, 1.5, 5, 9, 10, 2.5, 0.1, 1, 2.5, 3.4, 6 }; //6 celých čísel

            Console.WriteLine($"Počet celých čísel v poli cisla je {PocetCelych(cisla)}");

            //int cela_cisla = PocetCelych(cisla);

            int[] celaCisla = CelaCisla(cisla);
            foreach (int cislo in celaCisla)
            {
                Console.WriteLine(cislo);
            }

        }

        static int[] CelaCisla(double[] numbers)
        {
            int[] vysledek = new int[0];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 1 == 0)
                {
                    Array.Resize(ref vysledek, vysledek.Length + 1);
                    vysledek[vysledek.Length - 1] = (int) numbers[i];
                }
            }

            return vysledek;
        }

        static int PocetCelych(double[] numbers)
        {
            int pocet_celych = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 1 == 0)
                {
                    pocet_celych++;
                }
            }
           return pocet_celych;

        }
    }
}
