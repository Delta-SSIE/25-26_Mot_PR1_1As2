namespace Prace_TXT
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //WRITEALLTEXT a READALLTEXT
            string txt = "Tenhle text se zapíše do souboru!";

            //Zapíše obsah proměnné txt do text.txt, pokud by tam něco bylo, tak to přepíše
            //projektová složka -> bin -> debug -> net 9.0
            File.WriteAllText("text.txt", txt);

            //Načte text jako jeden string
            Console.WriteLine(File.ReadAllText("text.txt"));

            //WRITEALLLINES a READALLLINES

            string[] poleTxt = ["První řádek", "Druhý řádek", "Třetí řádek"];
            //Zapíše data z kolekce jako jednotlivé řádky 
            File.WriteAllLines("text2.txt", poleTxt);

            string[] vystup = File.ReadAllLines("text2.txt");
            foreach(string radek in vystup)
            {
                Console.WriteLine(radek);
            }

            //APPEND - přidává do souboru
            File.AppendAllText("text.txt", "Ahooooj");
            File.AppendAllLines("text2.txt", vystup);
            File.AppendAllText("text3.txt", "DATA");
        }
    }
}
