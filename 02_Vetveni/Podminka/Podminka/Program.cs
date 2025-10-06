namespace Podminka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jednoduché využití porovnávací operátorů
            //Výstup je boolean, neboli hodnota TRUE, či FALSE
            Console.WriteLine($"Je 1 rovna 1: {1==1}");
            Console.WriteLine($"Je 2 jsou větší, nebo rovno 5: {2 >= 5}");
            //Jde to nejen s čísly... 
            Console.WriteLine($"Slovo \"ahoj\" je stejné jako slovo \"ahoj\": {"ahoj"=="ahoj"}");

            //Podmínka IF

            //v kulaté závorce je statment, který pokud je true, tak se to, co je v hranatých závorkách spustí
            //statment vždy vychází z bool logiky, tedy true a false

            if(1 == 1)
            {
                Console.WriteLine("Podmínka je splněna!");
            }

            //Ukázka IF program číslo vyšší než 10
            Console.WriteLine("Napiš mi číslo:");
            int myInt = int.Parse(Console.ReadLine());
            
            //podmínka se spustí, pouze pokud hodnota myInt je vyšší než 10
            if(myInt > 10)
            {
                //Toto se nezobrazí, pokud myInt je menší, či roven 10
                Console.WriteLine("{0} je vyšší než číslo 10!",myInt);
            }

            //Podmínka if s negativní větví ELSE
            Console.WriteLine("Svítí na semaforu červené světlo? (a/n)");
            string odpoved = Console.ReadLine();

            if(odpoved == "a")
            //Toto je tělo podmínky, který se spustí, když se podmínak vyhodnotí jako TRUE
            {
                Console.WriteLine("Stůj a čekej na zelené světlo!");
            } else
            //Toto je část, co se spustí, když se podmínka vyhodnotí jako FALSE
            {
                Console.WriteLine("Můžeš přejít přechod!");
            }

            //Podmínka if s negativní větví ELSE IF (semafor 2.0)
            Console.WriteLine("Svítí na semaforu červené světlo? (a/n)");
            string odpoved2 = Console.ReadLine();

            if (odpoved2 == "a")
            //Toto je tělo podmínky, který se spustí, když se podmínak vyhodnotí jako TRUE
            {
                Console.WriteLine("Stůj a čekej na zelené světlo!");
            }
            else if(odpoved2 == "n")
            //Toto se spustí, pokud horní podmínka je vyhodnocena jako FALSE a tato podmínka vyhodnocena jako TRUE
            {
                Console.WriteLine("Můžeš přejít přechod!");
            } else
            //Toto se spustí, pokud obě podmínky jsou FALSE
            {
                Console.WriteLine("Neznámý vstup");
            } 

        }
    }
}
