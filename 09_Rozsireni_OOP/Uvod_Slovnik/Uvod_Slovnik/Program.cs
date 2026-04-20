namespace Uvod_Slovnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklarace slovníku
            Dictionary<string, int> TelefoniSeznam = new Dictionary<string, int>();

            //Přidávání prvků do slovníku
            TelefoniSeznam.Add("Adam", 777555222);
            TelefoniSeznam.Add("Eliška", 777111222);

            //Vypis ze slovníku
            Console.WriteLine(TelefoniSeznam["Adam"]);

            //Iterace slovníku
            //Iterace po klíčích
            foreach (string jmeno in TelefoniSeznam.Keys)
            {
                Console.Write(jmeno+ ": " + TelefoniSeznam[jmeno] + "\n");
            }
            //Iterace po hodnotách
            foreach (int cislo in TelefoniSeznam.Values)
            {
                Console.Write(cislo + "\n");
            }
            //Iterace po záznamech (klic/hodnota)
            foreach (KeyValuePair<string,int> zaznam in TelefoniSeznam)
            {
                Console.Write(zaznam.Key + ": " + zaznam.Value + "\n");
            }

            //Remove
            TelefoniSeznam.Remove("Adam");
            //Console.WriteLine(TelefoniSeznam["Adam"]);

            //Contains - ověření zda-li prvek je ve slovníku
            Console.WriteLine(TelefoniSeznam.ContainsValue(777111222));
            Console.WriteLine(TelefoniSeznam.ContainsKey("Eliška"));

        }
    }
}
