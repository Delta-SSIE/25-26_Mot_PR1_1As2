namespace List_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklarace listu
            List<int> SeznamCisel = new List<int>();
            //Incializace listu z pole
            string[] poleJmen = { "Pepa", "Karel", "Eliška" };
            List<string> SeznamJmen = new List<string>(poleJmen);

            //Přidávání prvků do listu
            SeznamCisel.Add(5);
            SeznamCisel.Add(10);
            SeznamJmen.Add("Jindřich");

            //Výpis prvků z listu
            Console.WriteLine(SeznamJmen[2]);
            Console.WriteLine(SeznamJmen[3]);
            Console.WriteLine(SeznamCisel[0]);

            //Přidávání většího počtu prvků
            SeznamCisel.AddRange(5, 1, 2);
            string[] dalsijmena = { "Karel", "Bětka" }; 
            SeznamJmen.AddRange(dalsijmena); //přidání celé kolekce
            Console.WriteLine(SeznamCisel[3]);

            //Atributy listu
            Console.WriteLine("----------------------");
            Console.WriteLine(SeznamCisel.Count);
            Console.WriteLine(SeznamCisel.Capacity);
            Console.WriteLine("----------------------");
            Console.WriteLine(SeznamJmen.Count);
            Console.WriteLine(SeznamJmen.Capacity);

            //For cyklus (iterace listem)
            for (int i = 0; i < SeznamJmen.Count; i++)
            {
                Console.Write(SeznamJmen[i] + " ");
            }
            Console.WriteLine();

            //Foreach
            foreach (int cislo in SeznamCisel)
            {
                Console.Write(cislo + " ");
            }
            Console.WriteLine();

            //INSERT
            SeznamJmen.Insert(0, "Lucie");
            //Lucie půjde na 0. index a zbytek se posune
            VypisList(SeznamJmen);

            //REMOVE
            SeznamJmen.Remove("Lucie"); //najde první prvek, který se shoduje a smaže ho z listu
            VypisList(SeznamJmen);
            SeznamJmen.RemoveAt(0); //smaže prvek na konkrétním indexu
            VypisList(SeznamJmen);
            SeznamJmen.RemoveRange(1,2);
            //první argument od jakého indexu a druhý kolik prvků
            VypisList(SeznamJmen);

            //INDEXOF
            Console.WriteLine(SeznamJmen.IndexOf("Karel")); //vrací 0. protože první karel je na nultém indexu
            Console.WriteLine(SeznamJmen.IndexOf("Franta")); //vrací -1, protože Franta neexistuje v listu
            Console.WriteLine(SeznamJmen.LastIndexOf("Karel")); //vrací 1, protože poslední karel je na 1. indexu

            //Sort
            SeznamCisel.Sort();
            foreach (int cislo in SeznamCisel)
            {
                Console.Write(cislo + " ");
            }
            Console.WriteLine();
            SeznamJmen.Sort();
            VypisList(SeznamJmen);

            //Reverse
            SeznamCisel.Reverse();
            foreach (int cislo in SeznamCisel)
            {
                Console.Write(cislo + " ");
            }
            Console.WriteLine();
            SeznamJmen.Reverse();
            VypisList(SeznamJmen);

            //Převod listu na pole
            string[] jmena = SeznamJmen.ToArray();

            //List objektů
            List<Item> SeznamObjektu = new List<Item>();
            for (int i = 0; i < 100; i++)
            {
                SeznamObjektu.Add(new Item());
            }
            foreach (Item item in SeznamObjektu)
            {
                Console.Write(item.ID + " ");
            }
        }

        static void VypisList(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
