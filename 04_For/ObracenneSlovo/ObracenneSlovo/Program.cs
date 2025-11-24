namespace ObracenneSlovo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Ahoj, jak se máš?";
            string text2 = "";

            //Načtení znak po znaku z textu do textu2
            for (int i = 0; i < text.Length; i++)
            {
                text2 += text[i];
                Console.WriteLine(text2);
            }

            string obraceny_text = "";

            //Načtení znak po znaku do obraceny_text odzadu textu
            for (int i = text.Length-1; i >= 0; i--)
            {
                obraceny_text += text[i];
                Console.WriteLine(obraceny_text);
            }
        }
    }
}
