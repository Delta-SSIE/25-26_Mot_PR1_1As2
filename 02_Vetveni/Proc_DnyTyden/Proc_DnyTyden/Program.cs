namespace Proc_DnyTyden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej mi pořadí dne v týdnu (1-7)");
            int den = int.Parse(Console.ReadLine());

            if(den == 1)
            {
                Console.WriteLine("Pondělí");
            } else if(den == 2)
            {
                Console.WriteLine("Úterý");
            } else if(den == 3)
            {
                Console.WriteLine("Středa");
            } else if(den==4) 
            {
                Console.WriteLine("Čtvrtek");
            } else if(den==5)
            {
                Console.WriteLine("Pátek");
            } else if(den == 6)
            {
                Console.WriteLine("Sobota");
            } else if(den == 7)
            {
                Console.WriteLine("Neděle");
            } else
            {
                Console.WriteLine("Špatně zadaný vstup!");
            }
        }
    }
}
