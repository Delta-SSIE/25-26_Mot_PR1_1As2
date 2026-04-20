namespace Zapouzdreni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predmet skrin = new Predmet();
            skrin.Name = "Skrin";
            Console.WriteLine(skrin.Name);

            skrin.Price = -20;
            Console.WriteLine(skrin.Price);
            skrin.Price = 10;
            Console.WriteLine(skrin.Price);

            Console.WriteLine(skrin.Weigth);
            skrin.Weigth = 50;
            Console.WriteLine(skrin.Weigth);
            skrin.Weigth += 70;
            Console.WriteLine(skrin.Weigth);
            skrin.Weigth += -120;
            Console.WriteLine(skrin.Weigth);

            Console.WriteLine(skrin.ID);
            // skrin.ID = 100; nelze protože set je private

        }
    }
}
