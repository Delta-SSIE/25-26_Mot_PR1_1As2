namespace caesar_zaklad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej text a já ho zašifruji, dle pevně zadaného posunu");
            string text = Console.ReadLine();

            string zasf_text = "";
            string des_text = "";

            int posun = 2;
            int pocitadlo = 0;

            while(pocitadlo < text.Length)
            {
                //uložím číslo v ASCII tabulce znaku v textu na indexu pocitadlo do proměnné s +1
                //Tzn. původní A (65) změním na číslo 66
                int cislo_znak = text[pocitadlo] + posun;
                //Kontrola kvůli přesahu u z
                if(cislo_znak > 122)
                {
                    cislo_znak -= 26;
                }
                //převedu cislo_znaku na znak (66 --> B)
                char znak = (char) cislo_znak;
                //k proměnné zasf_text přidám znak
                zasf_text += znak;
                pocitadlo++;
            }
            Console.WriteLine(zasf_text);
            pocitadlo = 0;

            while (pocitadlo < zasf_text.Length)
            {
                int cislo_znak = zasf_text[pocitadlo] - posun;
                if (cislo_znak < 97)
                {
                    cislo_znak += 26;
                }
                char znak = (char)cislo_znak;
                des_text += znak;
                pocitadlo++;
            }
            Console.WriteLine(des_text);
        }
    }
}
