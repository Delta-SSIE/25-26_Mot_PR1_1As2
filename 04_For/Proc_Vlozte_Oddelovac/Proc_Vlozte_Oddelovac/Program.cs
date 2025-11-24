namespace Proc_Vlozte_Oddelovac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "skolaDelta";
            char oddelovac = '/';

            string text_novy = "";
            // š/k/o/l/a/D/e/l/t/a

            for (int i = 0; i < text.Length; i++)
            {
                if(i == text.Length-1)
                {
                    text_novy += text[i];
                } else
                {
                    text_novy += text[i] + "" + oddelovac;
                    /*
                     * text_novy += text[i];
                     * text_novy += oddelovac;
                     */
                }

                Console.WriteLine(text_novy);
            }

            Console.WriteLine(text_novy);
        }
    }
}
