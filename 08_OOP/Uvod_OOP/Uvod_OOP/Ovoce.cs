using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uvod_OOP
{
    internal class Ovoce
    {
        //Veřejné položky
        public string nazev;
        public double hmotnost;
        public string barva;
        
        public string stav = "čerstvé";
        public string zemePuvodu;

        //Soukromé položky (get, set)
        private string chut = "kyselé";

        //Veřejné metody
        public void Snist()
        {
            Console.WriteLine("Mňam");
            stav = "snědeno";
            // this.stav = "snědeno";
        }
        public string GetChut()
        {
            return this.chut;
        }
        public void SetChut(string chutZadana)
        {
            this.chut = chutZadana;
        }
    }
}
