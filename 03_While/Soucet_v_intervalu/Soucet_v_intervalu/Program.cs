namespace Soucet_v_intervalu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zadej mi 1. číslo");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("zadej mi 2. číslo");
            int y = int.Parse(Console.ReadLine());

            //Zjištění max a min
            int max = Math.Max(x, y);
            int min = Math.Min(x, y);

            int soucet = 0;

            while (min <= max)
            {
                soucet += min;
                min++;
            }

            Console.WriteLine($"Součet čísel v intervalu je {soucet}");
        }
    }
}
