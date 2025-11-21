namespace String_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej mi slovo: ");
            string slovo = Console.ReadLine();

            /*Uživatel zadá:
             *AHOJ
             *
             *Program:
             *A
             *H
             *O
             *J
             */

            //podmínka říká, že dokud je i menší než délka stringu slovo
            for (int i = 0; i < slovo.Length; i++)
            {
                //slovo = "Ahoj"
                //A znak na 0. indexu
                //slovo[0] == 'A'
                Console.WriteLine(slovo[i]);
            }

            //Každý druhý znak ze slova
            for (int i = 0; i < slovo.Length; i+=2)
            {
                Console.Write(slovo[i]);
            }
            Console.WriteLine();

            //Vypsat jenom 'a'/'A' a 'o'/'O'
            for (int i = 0; i < slovo.Length; i++)
            {
                if (slovo[i] == 'a' || slovo[i] == 'o' || slovo[i] == 'A' || slovo[i] == 'O')
                {
                    Console.Write(slovo[i]);
                }
            }
        }
    }
}
