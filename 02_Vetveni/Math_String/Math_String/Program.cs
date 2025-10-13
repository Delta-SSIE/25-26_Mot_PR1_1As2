namespace Math_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MATH - matematické funkce/metody

            Console.WriteLine(Math.Max(5,8)); //metoda Max vrací větší ze dvou čísel
            Console.WriteLine(Math.Min(5, 8)); //metoda Min vrací menší ze dvou čísel

            Console.WriteLine(Math.Sqrt(24)); //Sqrt vrací druhou odmocninu ze zadaného čísla
            Console.WriteLine(Math.Abs(-22)); //Abs vrací absolutní hodnotu daného čísla

            Console.WriteLine(Math.PI); //vrací PI hodnotu (v doublu)
            Console.WriteLine(Math.Pow(2,5)); //mocnění - první číslo je to co bude mocněné, druhé čím se bude mocnit
            //příklad je 2 na 5tou

            //String 
            string txt = "Ahoj";

            //Délka textu
            //nazev_promenne.Length vrací délku daného řetězce
            Console.WriteLine(txt.Length);

            //Indexace stringu (práce s převodem na char)
            //Hranaté závorky = Pravý alt + F = [; Pravý alt + G = ]
            //hodnota v proměnné txt (string) na 0. indexu
            //txt = "Ahoj"
            //0. index = A
            //3. index = j
            Console.WriteLine(txt[0]);

            char prvni_pismeno = txt[0]; //vratí znak na 0. indexu
            Console.WriteLine(prvni_pismeno);
            char treti_pismeno = txt[3]; //vratí znak na 3. indexu
            Console.WriteLine(treti_pismeno);
            char posledni_pismeno = txt[txt.Length-1]; //vratí to znak na indexu, který se rovná délce řetězce -1
            //v našem případě je délka 4, tzn. 4-1=3
            Console.WriteLine(posledni_pismeno);

            //vrácení indexu znaku
            Console.WriteLine(txt.IndexOf('o')); //vrátí první index prvního výskytu znaku 'o' v rámci řetězce txt
            Console.WriteLine(txt.LastIndexOf('o')); //vrací poslední výskyt znaku 'o' v txt

            string slovo = "folklor";
            Console.WriteLine(slovo.IndexOf('o')); //první výskyt = 1
            Console.WriteLine(slovo.LastIndexOf('o')); //poslední výskyt = 5

            //Uživatel zadá znak a program mu řekne, jestli to je malé písmeno

            Console.WriteLine("Zadej mi jeden znak: ");
            //Načte jeden znak do proměnne znak
            char znak = Console.ReadKey().KeyChar;

            //Podmínka, co mi řekne, jestli to je malé písmeno, či ne!
            /* převod znaku na číslo
            int cislo_znak = znak;
            Console.WriteLine(cislo_znak);
            */

            //automaticky se znak převede na int
            //int hodnota charu je daná ASCII tabulkou
            //a=97
            //z=122
            //Malá abeceda je v číselném rozmezí 96 až 122
            if(znak > 96 && znak < 123)
            {
                Console.WriteLine("Jedná se znak z malé abecedy!");
            } else
            {
                Console.WriteLine("Nejedná se o znak z malé abecedy!");
            }


            //Program na jaké písmeno začíná zadané slovo
            Console.WriteLine("Zadej mi slovo");
            string word = Console.ReadLine();

            if (word[0] > 96 && word[0] < 123)
            {
                Console.WriteLine("Slovo začíná malým písmenem!");
            } else if (word[0] > 64 && word[0] < 91) //velká abeceda od 65 do 90
            {
                Console.WriteLine("Slovo začíná velkým písmenem!");
            } else
            {
                Console.WriteLine("Slovo nezačíná písmenem, ale číslem nebo spec. znakem!");
            }
        }
    }
}
