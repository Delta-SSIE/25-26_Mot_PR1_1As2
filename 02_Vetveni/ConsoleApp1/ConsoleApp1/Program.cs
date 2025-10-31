namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej mi procenta z testu.");
            int procenta = int.Parse(Console.ReadLine());

            switch(procenta)
            {
                case int x when x <= 100 && x >= 95:
                    Console.WriteLine("1");
                    break;
                case int x when x <= 94 && x >= 85:
                    Console.WriteLine("2");
                    break;
                case int x when x <= 84 && x >= 70:
                    Console.WriteLine("3");
                    break;
                case int x when x <= 69 && x >= 60:
                    Console.WriteLine("4");
                    break;
                case int x when x >= 0:
                    Console.WriteLine("5");
                    break;
                default:
                    Console.WriteLine("Špatný vstup");
                    break;
            }
        }
    }
}
