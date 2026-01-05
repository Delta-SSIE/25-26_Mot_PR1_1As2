namespace Resize_Pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = { 1, 2, 5, 10 }; //má velikost 4
            int[] prazdna_cisla = new int[10]; //prázdné pole s velikostí 10

            //změna hodnota na indexu
            cisla[2] = 15;
            prazdna_cisla[0] = 300;
            prazdna_cisla[prazdna_cisla.Length - 1] = 200;
            prazdna_cisla[5] = 5;
            // cisla[5] = 5; nelze indexovat

            //RESIZE
            Array.Resize(ref cisla, 2); //změní velikost pole cisla na 2
            Array.Resize(ref prazdna_cisla, 5); //změní velikost pole prazdna_cisla na 5

            foreach (int cislo in cisla)
            {
                Console.Write(cislo + " ");
            }
            Console.WriteLine();

            foreach (int cislo in prazdna_cisla)
            {
                Console.Write(cislo + " ");
            }
            Console.WriteLine();


            int[] posloupnost = new int[0];
            for (int i = 0; i < 1000; i++)
            {
                Array.Resize(ref posloupnost, posloupnost.Length + 1); //zvětšení pole posloupnost o 1
                posloupnost[i] = i;
            }
            Console.WriteLine();
            Console.WriteLine(posloupnost.Length);
        }
    }
}
