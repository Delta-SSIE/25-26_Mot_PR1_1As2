namespace Operatory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aritmetické operátory

            //Modulo - zbytek po celočíselném dělení
            Console.WriteLine(65 % 60); //5

            //Increasment and decrement
            int i = 0;
            i++; //+1
            i++; //+1
            Console.WriteLine(i); //2
            i--; //-1
            i--; //-1
            Console.WriteLine(i); //0

            //Přiřazovací operátory
            int x = 0; // = přiřazení hodnoty k dané proměnné
            
            x = x + 3; //zvyší hodnotu x o 3 (neboli) x si přiřadí hodnotu x + 3
            x += 3; //to je zkráceně x = x + 3
            x -= 3; //x = x - 3
            x %= 3; // x = x % 3


            //Porovnávací operátory
            Console.WriteLine(1 == 1); //== je 'rovná se'
            Console.WriteLine(1 == 0);
            Console.WriteLine(5 > 8); // > větší než (5 je větší než 8)
            //ALTGR + , = <; ALTGR + . = > 
            Console.WriteLine(5 < 5); //5 je menší než 5
            Console.WriteLine(5 <= 5); //5 je menší, nebo se rovná 5
            //nerovná se:
            Console.WriteLine(1 != 1); //1 se nerovná 1
            Console.WriteLine(1 != 5); //1 se nerovná 5


        }
    }
}
