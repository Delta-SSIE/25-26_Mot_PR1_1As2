using System.Security.Cryptography;

namespace Proc_CislaDoTabulky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] cisla =
            {
                {100, 105, 50, 10051 },
                {5, 5, 40, 4000 },
                {25, 1, 80, 30 }
            };

            VypisTabulku(cisla);

        }

        static void VypisTabulku(int[,] pole)
        {
            /*
             * | 5 | 10 | 50 | 100 |
             * ---------------------
             * | 5 | ...
             */

            for (int i = 0; i < pole.GetLength(0); i++)
            {
                int pocet_spoj = 0;
                Console.Write("|");
                pocet_spoj++;
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    int pocetznak = 1;
                    for (int k = 0; k < pole.GetLength(0); k++)
                    {
                        if (pocetznak < Convert.ToString(pole[k, j]).Length)
                        {
                            pocetznak = Convert.ToString(pole[k, j]).Length;
                        }
                    }
                    int pocetmezer = pocetznak - Convert.ToString(pole[i, j]).Length;
                    pocet_spoj += pocetznak;
                    for (int n = 0; n < pocetmezer; n++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write($"{pole[i, j]}");
                    Console.Write("|");
                    pocet_spoj++;
                }
                Console.WriteLine();
                for (int j = 0; j < pocet_spoj; j++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();

            }
        }
    }
}
