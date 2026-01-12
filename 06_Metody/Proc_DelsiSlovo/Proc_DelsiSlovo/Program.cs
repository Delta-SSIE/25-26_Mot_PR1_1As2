namespace Proc_DelsiSlovo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej mi slovo A");
            string slovoA = Console.ReadLine();
            Console.WriteLine("Zadej mi slovo B");
            string slovoB = Console.ReadLine();

            Console.WriteLine($"Ze zadaných slov {slovoA} a {slovoB} je delší {JeDelsi(slovoA,slovoB)}");
        }

        static string JeDelsi(string a, string b)
        {
            if(a.Length > b.Length)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
