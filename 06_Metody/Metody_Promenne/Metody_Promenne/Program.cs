namespace Metody_Promenne
{
    internal class Program
    {
        static int cisloStat = 0;
        static void Main(string[] args)
        {
            string[] poleJmen;
            int index;

            //Vrátí dvě hodnoty
            //int se uloží do indexu
            //string[] uloží do poleJmen
            (index, poleJmen) = VratIndexaPole();
            Console.WriteLine(poleJmen[index]);

            //Reference
            int x = 5;
            Nasob(ref x);
            Nasob(ref x);
            Console.WriteLine(x);

            //Out
            int y;
            Nasob2(out y);
            Console.WriteLine(y);

            //Statická proměnná
            cisloStat++;
            cisloStat++;
            Plus();
            Plus();
            Console.WriteLine(cisloStat);


        }

        //Tuple 
        //Metoda vrací dvě hodnoty - jeden int a jedno pole stringů
        static (int, string[]) VratIndexaPole()
        {
            int index = 5;
            string[] pole = { "Pepa", "Jarmil", "Lukáš", "Zdena", "Kačka", "Ludmila" };

            return (index, pole);
        }
        static void Nasob(ref int cislo)
        {
            cislo *= 2;
        }

        static void Nasob2(out int cislo)
        {
            cislo = 5;
            cislo *= 2;
        }

        static void Plus()
        {
            cisloStat++;
        }
    }
}
