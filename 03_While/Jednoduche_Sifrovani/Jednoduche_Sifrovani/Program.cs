namespace Jednoduche_Sifrovani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sif_znak = ' ';
            char zasf_znak = ' ';
            Console.WriteLine("Zadej mi znak, kterým budeme zaměňovat znaky v textu");
            do
            {
                sif_znak = Console.ReadKey().KeyChar;
            } while (!((sif_znak >= 65 && sif_znak <= 90)||(sif_znak >= 97 && sif_znak <= 122)));
            Console.WriteLine("Zadej mi znak, který budeme v textu šifrovat");
            do
            {
                zasf_znak = Console.ReadKey().KeyChar;
            } while (!((zasf_znak >= 65 && zasf_znak <= 90) || (zasf_znak >= 97 && zasf_znak <= 122)));

            Console.WriteLine("Zadej mi text, který budu šifrovat");
            string puv_text = Console.ReadLine();

            string sif_text = "";
            string des_text = "";

            int pocitadlo = 0;

            while(pocitadlo < puv_text.Length)
            {
                if (puv_text[pocitadlo] == zasf_znak)
                {
                    sif_text += sif_znak;
                } else
                {
                    sif_text += puv_text[pocitadlo];
                }
                pocitadlo++;
            }

            Console.WriteLine(sif_text);

            pocitadlo = 0;

            while (pocitadlo < sif_text.Length)
            {
                if (sif_text[pocitadlo] == sif_znak)
                {
                    des_text += zasf_znak;
                }
                else
                {
                    des_text += sif_text[pocitadlo];
                }
                pocitadlo++;
            }

            Console.WriteLine(des_text);

        }
    }
}
