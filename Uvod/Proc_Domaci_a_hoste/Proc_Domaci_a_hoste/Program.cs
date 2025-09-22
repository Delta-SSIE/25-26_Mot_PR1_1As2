namespace Proc_Domaci_a_hoste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej skore domácích: ");
            string domaci = Console.ReadLine();

            Console.Write("Zadej skore hostů: ");
            string hoste = Console.ReadLine();

            Console.WriteLine("Výsledek zápasu je " + domaci + ":" +hoste);

            //Výpis do konzole bez použití proměnná + string

            //Výpis pomocí placeholderů a $ (na začátku musí být)
            Console.WriteLine($"Výsledek zápasu je {domaci}:{hoste}");
            //složené závorky ({}) ALTGR + B a ALTGR + N
            //dollar ($) se píše ALTGR+ů

            //Výpis pomocí pořadových čísel
            Console.WriteLine("Výsledek zápasu je {0}:{1}", domaci,hoste);
            //0 - domaci
            //1 - hoste
            //pořadová čísla jsou od 0, první za "" je proměnná, která jde na místo {0}

        }
    }
}
