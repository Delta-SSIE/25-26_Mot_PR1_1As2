namespace Konstruktory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human pepik = new Human("Jozef", 22);
            Human[] civilization = {pepik};

            do
            {
                Console.WriteLine("Zadej mi jméno nového člověka");
                string name = Console.ReadLine();
                Console.WriteLine("Zadej mi věk nového člověka");
                int age = 0;
                while (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("zadej číslo");
                }
                Array.Resize(ref civilization, civilization.Length + 1);
                civilization[civilization.Length - 1] = new Human(name, age);
            } while (civilization.Length < 3);


            for (int i = 0; i < civilization.Length; i++)
            {
                civilization[i].Introduction();
            }


        }
    }
}
