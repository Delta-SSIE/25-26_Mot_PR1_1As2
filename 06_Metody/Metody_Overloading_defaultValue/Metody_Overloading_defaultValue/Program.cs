namespace Metody_Overloading_defaultValue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Scitani();
            Scitani(1);
            Scitani(5);

            Nasobeni(5, 5); //zavolá Nasobeni(int x, int y)
            Nasobeni(1.5, 2.5); //zavolá Nasobeni(double x, double y)

            
        }

        //Method Overloading
        //Dvě metody se stejný názvem, pracující s jiným dat. typem parametrů
        //Program volá danou metodu, dle vstupních argumentů
        static void Nasobeni (int x, int y)
        {
            Console.WriteLine(x*y);
        }

        static void Nasobeni(double x, double y)
        {
            Console.WriteLine(x*y);
        }

        //Metoda má výchozí hodnoty pro x a y, lze jí volat bez argumentů
        static void Scitani(int x = 0, int y = 0)
        {
            Console.WriteLine(x+y);
        }
    }
}
