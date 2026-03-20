namespace Skolni_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Skola delta = new Skola("Delta");
            Skola dasak = new Skola("Gymnázium Pardubice, Dašická");


            dasak.PridejStudenty(100);
            delta.PridejStudenty(30);
            delta.PridejStudenty(50);

            //delta.VypisStudenty();

            while (true)
            {
                Console.WriteLine("Vyber studenta, který má obdržet známku");
                delta.VypisStudenty();
                int id = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Z jakého předmětu známka bude?");
                string predmet = Console.ReadLine();
                Console.WriteLine("Jakou váhu bude mít?");
                int vaha = int.Parse(Console.ReadLine());
                Console.WriteLine("Jaká známka to bude?");
                int znamka = int.Parse(Console.ReadLine());
                delta.DejZnamkuStudentovi(id, znamka, vaha, predmet);
                Console.Clear();

                for (int i = 0; i < delta.studenti.Length; i++)
                {
                    delta.studenti[i].VypisZnamky();
                }
                Console.ReadKey();
            }
        }
    }
}
