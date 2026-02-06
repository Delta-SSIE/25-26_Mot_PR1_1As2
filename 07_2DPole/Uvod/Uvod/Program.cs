namespace Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla; //jednorozměrné pole
            int[,] cisla2Dblank; //dvourozměrné pole (prázdné)

            string[,] prazdnePole = new string[5, 3];
            //prázdné pole o 5 řádcích a 3 sloupcích

            int[,] cisla2D = { {5, 2, 5 }, { 5, 2, 2} }; //dvourozměrné pole

            //Indexace 2D pole
            //[indexRadku, indexSloupce]
            Console.WriteLine(cisla2D[0,1]); //2
            //nultý řádek, 1 sloupec

            cisla2D[0, 0] = 10;
            Console.WriteLine(cisla2D[0, 0]);

            prazdnePole[4, 1] = "Slovo";
            Console.WriteLine(prazdnePole[4, 1]);

            //Průchod 2D polem
            //Foreach - projde celou kolekci
            //jde vždy po řádcích (tzn. vypíše všechny hodnoty na řádku a pak jde na další řádek)
            foreach  (int cislo in cisla2D)
            {
                Console.Write(cislo + " ");
            }
            Console.WriteLine();

            //Průchod 2D polem přes dva for cykly
            
            //GetLength
            Console.WriteLine(prazdnePole.GetLength(0)); //Vypíše počet řádků
            Console.WriteLine(prazdnePole.GetLength(1)); //Vypíše počet sloupců

            //Dva for cykly pro průchod 2D pole
            //Vnější for cyklus prochází pole po řádcích
            for (int i = 0; i < cisla2D.GetLength(0); i++)
            {
                //Vnitřní for cyklus prochází pole po sloupcích
                for (int j = 0; j < cisla2D.GetLength(1); j++)
                {
                    Console.Write(cisla2D[i,j] + " ");
                    //i - řádek; j - sloupec
                }
                Console.WriteLine();
            }

        }
    }
}
