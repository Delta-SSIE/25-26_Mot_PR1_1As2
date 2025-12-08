namespace Proc_Teploty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] teploty = { 13.7, 14.2, 14.3, 14.8, 15.2, 16.0, 16.3, 17.1 };

            //5:30 první měření
            //každé další během 30 minut

            int hodiny = 5;
            int minuty = 30;

            //Výpis
            // 05:30 | 13,7°C

            foreach (double teplota in teploty)
            {
                //cislo:00 znamená, že chci vypsat 2 čísla
                Console.WriteLine($"{hodiny:00}:{minuty:00} | {teplota}°C");
                minuty += 30;
                if(minuty == 60)
                {
                    minuty = 0;
                    hodiny++;
                }

            }
        }
    }
}
