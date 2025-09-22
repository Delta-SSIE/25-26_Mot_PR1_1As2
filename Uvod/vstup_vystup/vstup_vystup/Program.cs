namespace vstup_vystup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Výpis pro uživatele do konzole
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Ahoj světe!");
            Console.WriteLine("Ahoj Jan!");

            //Console.Write
            Console.Write("Ahoj");
            Console.Write(" světe2!"); //Tohle je ve stejném řádku jako Ahoj
            Console.WriteLine(" Bude tohle ve stejném řádku?"); //ano bude, protože se řádek zalomí až za textem

            //Proměnné!
            //Deklarace proměnné
            //typ nazev_promenne
            string jmeno;
            //pojmenování proměnné víceslovně = jednoslovo_druheslovo nebo jednoslovoDruheslovo
            int cele_cislo;
            int celeCislo;

            //Inicializace proměnné
            string name = "Honza"; //nezapomenout na uvozovky
            int myInt = 5;

            Console.WriteLine(name);
            Console.WriteLine(myInt);
            // Console.WriteLine(jmeno); nelze vypsat proměnnou bez hodnoty
            
            //Přiřazení hodnoty k proměnné
            jmeno = "Jan"; //nazev_promenné = hodnota
            Console.WriteLine(jmeno);

            //Co se stane, když přiřadím hodnotu k proměné, co už nějakou hodnotu má?
            name = "John"; //přepíše původní hodnotu "Honza"
            Console.WriteLine(name);

            //Lze incializovat více proměnných najednou
            int x = 5, y = 5;
            Console.WriteLine(x);
            Console.WriteLine(y);

            //Inicializace konstanty (nelze měnit hodnotu, jen číst)
            const int kons_x = 5;

            //Výpis proměnných do konzole
            //lepím string ke stringu
            Console.WriteLine(name + " is your name!");
            Console.WriteLine("How dare you, " + name + "?!");
            //dvě proměnné (dva stringy
            Console.WriteLine(name + " is in Czech: " + jmeno);
            Console.WriteLine(name + " is " + myInt + " years old!");
            //když napíšu int+int ve výpisu, tak se vypíšou vedle sebe, pokud se přiřazují k dalšímu stringu
            //když napíšu (int+int) sečtou se
            Console.WriteLine("x value is " + x + "; y value is " + y + " and what is this: " + (x+y));
            Console.WriteLine(x+y); //bez stringu se automaticky budou sčítat

            //Vstup od uživatele
            Console.WriteLine("Napiš mi své jméno?");
            //ReadLine() je metoda, která bere výstup z konzole
            //a ukládá ho jako string
            string username = Console.ReadLine(); //hodnota bude napsána uživatelem v konzoli!
            Console.WriteLine("Ahoj "+username+"!"); //vypíšu hodnotu proměnné




        }
    }
}
