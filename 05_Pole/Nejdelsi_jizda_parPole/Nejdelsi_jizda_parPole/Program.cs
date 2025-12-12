namespace Nejdelsi_jizda_parPole
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int[] jizdy = {
                247,
                135,
                15,
                23,
                428,
                63,
                26,
                7
                };

                string[] ridici = {
                "Petr",
                "Pavel",
                "Jaroslav",
                "Pavel",
                "Jaroslav",
                "Petr",
                "Pavel",
                "Petr"
                };

            //Který řidič ujel nejdelší jízdu

            //Hledání nejdelší jízdy
            int nej_jizda = int.MinValue;

            //foreach (int delka_jizdy in jizdy)
            //{
            //    if(nej_jizda < delka_jizdy)
            //    {
            //        nej_jizda = delka_jizdy;
            //    }
            //}

            int index_nejJizdy = 0;

            for (int i = 0; i < jizdy.Length; i++)
            {
                if (nej_jizda < jizdy[i])
                {
                    nej_jizda = jizdy[i];
                    index_nejJizdy = i;
                }
            }

            Console.WriteLine($"Nejdelší jízda byla dlouhá {nej_jizda} a nachází se na {index_nejJizdy} indexu v poli jízdy");
            Console.WriteLine($"Řidič, který jel tu jízdu je na indexu {index_nejJizdy} v poli ridici a je to {ridici[index_nejJizdy]}");

            //Nejkratší jízda a kdo jí jel?

            nej_jizda = int.MaxValue;
            index_nejJizdy = 0;

            for (int i = 0; i < jizdy.Length; i++)
            {
                if (nej_jizda > jizdy[i])
                {
                    nej_jizda = jizdy[i];
                    index_nejJizdy = i;
                }
            }

            Console.WriteLine($"Nejkratší jízda byla dlouhá {nej_jizda} a nachází se na {index_nejJizdy} indexu v poli jízdy");
            Console.WriteLine($"Řidič, který jel tu jízdu je na indexu {index_nejJizdy} v poli ridici a je to {ridici[index_nejJizdy]}");


        }
    }
}
