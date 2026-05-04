namespace StreamReader_StreamWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cestaLogu = "zaznamy.txt";

            // Druhý parametr 'true' znamená, že text se bude na konec souboru PŘIDÁVAT (nepřepíše ho)
            using (StreamWriter sw = new StreamWriter(cestaLogu, true))
            {
                sw.WriteLine("Začátek nového záznamu");

                for (int i = 1; i <= 5; i++)
                {
                    sw.WriteLine($"Záznam číslo: {i}");
                }
            } // Zde se StreamWriter automaticky zavře

            using (StreamReader sr = new StreamReader(cestaLogu))
            {
                string radek;

                // Čteme postupně, dokud metoda ReadLine nevrátí null
                while ((radek = sr.ReadLine()) != null)
                {
                    Console.WriteLine(radek);
                }
            }
        }
    }
}
